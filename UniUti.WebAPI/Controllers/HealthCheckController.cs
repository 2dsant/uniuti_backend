using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace UniUti.Controllers
{
    [ApiController]
    [Route("api/v1/info")]
    [AllowAnonymous]
    public class HealthCheckController : ControllerBase
    {
        /// <summary>
        /// </summary>
        /// <returns></returns>
        [HttpGet("live")]
        [SwaggerOperation(
        Summary = "EndPoint para Devops"
        )]
        [SwaggerResponse(200)]
        [SwaggerResponse(404)]
        [SwaggerResponse(500)]
        public IActionResult Live()
        {
            return Ok(DateTime.Now);
        }
    }
}