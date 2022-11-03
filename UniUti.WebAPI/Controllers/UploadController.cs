using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UniUti.Domain.Interfaces;
using UniUti.WebAPI.ViewModels;

namespace UniUti.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UploadController : ControllerBase
    {
        private IUploadService _uploadService;

        public UploadController(IUploadService uploadService)
        {
            _uploadService = uploadService;
        }

        [HttpPost("upload-image")]
        public async Task<ActionResult<string>> UploadImage([FromBody] ImageBase64 image)
        {
            return await _uploadService.UploadBase64Image(image.Image);
        }
    }
}
