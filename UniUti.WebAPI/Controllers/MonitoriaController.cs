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
    public class MonitoriaController : ControllerBase
    {
        private readonly IMonitoriaService _service;

        public MonitoriaController(IMonitoriaService service)
        {
            _service = service ??
                throw new ArgumentNullException(nameof(service));
        }

        [HttpGet("FindAll")]
        public async Task<ActionResult<IEnumerable<MonitoriaResponseVO>>> FindAll()
        {
            var monitorias = await _service.FindAll();
            if (monitorias == null) return NotFound();
            return Ok(new ResultViewModel
            {
                Success = true,
                Data = monitorias
            });
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<MonitoriaResponseVO>> FindById(string id)
        {
            var monitoria = await _service.FindById(id);
            if (monitoria == null) return NotFound();
            return Ok(new ResultViewModel
            {
                Success = true,
                Data = monitoria
            });
        }

        [HttpGet("GetByStatus/{status}")]
        public async Task<ActionResult<MonitoriaResponseVO>> FindByStatus(long status)
        {
            var monitoria = await _service.FindByStatus(status);
            if (monitoria == null) return NotFound();
            return Ok(new ResultViewModel
            {
                Success = true,
                Data = monitoria
            });
        }

        [HttpGet("FindByUser/{idUser}")]
        public async Task<ActionResult<MonitoriaResponseVO>> FindByUser(string idUser)
        {
            var monitoria = await _service.FindByUser(idUser);
            if (monitoria == null) return NotFound();
            return Ok(new ResultViewModel
            {
                Success = true,
                Data = monitoria
            });
        }

        [HttpPost("Create")]
        public async Task<ActionResult<MonitoriaResponseVO>> Create
        ([FromBody] MonitoriaCreateVO vo)
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
        public async Task<ActionResult<MonitoriaResponseVO>> Update
            ([FromBody] MonitoriaUpdateVO vo)
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
    }
}