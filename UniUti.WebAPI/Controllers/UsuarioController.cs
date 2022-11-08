using Microsoft.AspNetCore.Authorization;
using UniUti.Application.ValueObjects;
using UniUti.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace UniUti.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsuarioController : ControllerBase
    {
        private IAuthenticateService _authentication;

        public UsuarioController(IAuthenticateService authentication)
        {
            _authentication = authentication;
        }

        [HttpPost("get-user-by-email")]
        public async Task<ActionResult<UsuarioResponseVO>> GetUserByEmail(string email)
        {
            return await _authentication.GetUserByEmail(email);
        }

        [HttpPost("get-user-by-id")]
        public async Task<ActionResult<UsuarioResponseVO>> GetUserById(string email)
        {
            return await _authentication.GetUserById(email);
        }
    }
}
