using Microsoft.AspNetCore.Authorization;
using UniUti.Application.ValueObjects;
using Microsoft.AspNetCore.Identity;
using UniUti.Application.Interfaces;
using UniUti.Infra.Data.Identity;
using Microsoft.AspNetCore.Mvc;
using UniUti.WebAPI.ViewModels;
using System.Security.Claims;
using UniUti.WebAPI.Filters;
using UniUti.Domain.Interfaces;

namespace UniUti.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [ServiceFilter(typeof(ApiLoggingFilter))]
    public class AuthController : ControllerBase
    {
        private IAuthenticateService _authentication;
        private IUploadService _uploadService;

        public AuthController(IAuthenticateService authentication, IUploadService uploadService)
        {
            _authentication = authentication ??
                throw new ArgumentNullException(nameof(authentication));
            _uploadService = uploadService;
        }

        [AllowAnonymous]
        [HttpPost("LoginUser")]
        public async Task<ActionResult<ResultViewModel>> Login([FromBody] LoginModel userInfo)
        {
            var result = await _authentication.Authenticate(userInfo.Email, userInfo.Password);
            if (!result.Success)
            {
                return BadRequest(new ResultViewModel
                {
                    Success = false,
                    Errors = new List<string> { "Credenciais incorretas." }
                });
            }
            return new ResultViewModel
            {
                Success = true,
                Data = result
            };
        }

        [HttpPost("CreateUser")]
        public async Task<ActionResult> CreateUser([FromBody] UsuarioRegistroVO userInfo)
        {
            string imgUser = String.Empty;
            var existUser = await _authentication.GetUserByEmail(userInfo.Email);
            if (existUser is not null) return BadRequest("Email já cadastrado.");
            if(userInfo.ImageUrl != null)
            {
                imgUser = await _uploadService.UploadBase64Image(userInfo.ImageUrl);
                userInfo.ImageUrl = imgUser;
            }
            var result = await _authentication.RegisterUser(userInfo);
            return Ok(new ResultViewModel
            {
                Success = true,
                Data = result
            });
        }

        [HttpPost("refresh-login")]
        public async Task<ActionResult<UserToken>> RefreshLogin()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var usuarioId = identity?.FindFirst("id")?.Value;
            if (usuarioId == null)
                return BadRequest();

            var resultado = await _authentication.RefreshToken(usuarioId);

            if (resultado.Success)
                return Ok(resultado);

            return Unauthorized(resultado);
        }
    }
}