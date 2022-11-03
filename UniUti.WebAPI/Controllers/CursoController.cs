using UniUti.Application.ValueObjects.Responses;
using Microsoft.AspNetCore.Authorization;
using UniUti.Application.ValueObjects;
using UniUti.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using UniUti.WebAPI.ViewModels;
using UniUti.WebAPI.Filters;

namespace UniUti.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [ServiceFilter(typeof(ApiLoggingFilter))]
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _service;

        public CursoController(ICursoService service)
        {
            _service = service ??
                throw new ArgumentNullException(nameof(service));
        }

        [HttpGet("FindAll")]
        public async Task<ActionResult<ResultViewModel>> FindAll()
        {
            var cursos = await _service.FindAll();
            if (!cursos.Any()) return NoContent();
            return Ok(new ResultViewModel
            {
                Success = true,
                Data = cursos
            });
        }

        [HttpGet("FindById/{id}")]
        public async Task<ActionResult<ResultViewModel>> FindById(string id)
        {
            var curso = await _service.FindById(id);
            if (curso == null) return NotFound();
            return Ok(new ResultViewModel
            {
                Success = true,
                Data = curso
            });
        }

        [HttpPost("Create")]
        [Authorize]
        public async Task<ActionResult<ResultViewModel>> Create([FromBody] CursoCreateVO vo)
        {
            if (ModelState.IsValid)
            {
                await _service.Create(vo);
                return Ok(new ResultViewModel
                {
                    Success = true,
                    Data = vo
                });
            }
            else
            {
                return BadRequest(ModelState.Values);
            }
        }

        [HttpPut("Update")]
        [Authorize]
        public async Task<ActionResult<ResultViewModel>> Update([FromBody] CursoUpdateVO vo)
        {
            if (ModelState.IsValid)
            {
                await _service.Update(vo);
                return Ok(new ResultViewModel
                {
                    Success = true,
                    Data = vo
                });
            }
            else
            {
                return BadRequest(ModelState.Values);
            }
        }

        [HttpDelete("Delete/{id}")]
        [Authorize]
        public async Task<ActionResult<ResultViewModel>> Delete(string id)
        {
            var response = await _service.Delete(id);
            if (!response) return NotFound();
            return Ok(new ResultViewModel
            {
                Success = true,
            });
        }
    }
}