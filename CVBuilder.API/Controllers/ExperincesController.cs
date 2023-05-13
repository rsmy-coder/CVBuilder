using CVBuilder.Core.Dto;
using CVBuilder.Infostructure.Services.ExperincecService;
using Microsoft.AspNetCore.Mvc;

namespace CVBuilder.API.Controllers
{
    public class ExperincesController : BaseController
    {
        private readonly IExperincecService _educationService;

        public ExperincesController(IExperincecService educationService)
        {
            _educationService = educationService;
        }
        [HttpGet]
        public IActionResult Get(string UserId)
        {
            var x = _educationService.Get(UserId);
            return Ok(GetResponse(x));
        }
        [HttpPost]
        public IActionResult Create([FromBody] List<CreateExperinsesDto> dto, string UserId)
        {
            var CreateEducation = _educationService.Create(dto, UserId);
            return Ok(GetResponse(CreateEducation));
        }

        [HttpDelete]
        public IActionResult Delete(string UserId)
        {
            var deleteId = _educationService.Delete(UserId);
            return Ok(GetResponse(deleteId));
        }
    }
}
