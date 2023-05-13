using CVBuilder.Core.Dto;
using CVBuilder.Infostructure.Services.AwardService;
using CVBuilder.Infostructure.Services.SkillesService;
using Microsoft.AspNetCore.Mvc;

namespace CVBuilder.API.Controllers
{
    public class SkillesController : BaseController
    {
        private readonly ISkillesService _educationService;

        public SkillesController(ISkillesService educationService)
        {
            _educationService = educationService;
        }
        [HttpGet]
        public IActionResult Get(string UserId)
        {
          var x =  _educationService.Get(UserId);
            return Ok(GetResponse(x));
        }
        [HttpPost]
        public IActionResult Create([FromBody] List<CreateSkillAwordDto> dto , string UserId)
        {
            var CreateEducation = _educationService.Create(dto,UserId);
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
