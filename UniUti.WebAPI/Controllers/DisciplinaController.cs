using UniUti.Application.ValueObjects.Responses;
using Microsoft.AspNetCore.Authorization;
using UniUti.Application.ValueObjects;
using UniUti.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using UniUti.WebAPI.ViewModels;
using UniUti.WebAPI.Filters;

namespace UniUti.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    [ServiceFilter(typeof(ApiLoggingFilter))]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaService _service;

        public DisciplinaController(IDisciplinaService service)
        {
            _service = service ??
                throw new ArgumentNullException(nameof(service));
        }

        [HttpGet("FindAll")]
        public async Task<ActionResult<ResultViewModel>> FindAll()
        {
            var disciplinas = await _service.FindAll();
            if (disciplinas == null) return NotFound();
            return Ok(new ResultViewModel
            {
                Success = true,
                Data = disciplinas
            });
        }

        [HttpGet("FindById/{id}")]
        public async Task<ActionResult<ResultViewModel>> FindById(string id)
        {
            var disciplina = await _service.FindById(id);
            if (disciplina == null) return NotFound();
            return Ok(new ResultViewModel
            {
                Success = true,
                Data = disciplina
            });
        }

        [HttpPost("Create")]
        public async Task<ActionResult<ResultViewModel>> Create([FromBody] DisciplinaCreateVO vo)
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
        public async Task<ActionResult<ResultViewModel>> Update([FromBody] DisciplinaUpdateVO vo)
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