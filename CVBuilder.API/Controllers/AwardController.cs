using CVBuilder.Core.Dto;
using CVBuilder.Infostructure.Services.AwardService;
using Microsoft.AspNetCore.Mvc;

namespace CVBuilder.API.Controllers
{
    public class AwardController : BaseController
    {
        private readonly IAwardService _educationService;

        public AwardController(IAwardService educationService)
        {
            _educationService = educationService;
        }   

        [HttpGet]
        public IActionResult Get(string UserId)
        {
            var Award = _educationService.Get(UserId);
            return Ok(GetResponse(Award));
        }
        [HttpPost]
        public IActionResult Create([FromBody] List<CreateSkillAwordDto> dto, string UserId)
        {
            var CreateEducation = _educationService.Create(dto , UserId);
            return Ok(GetResponse(CreateEducation));
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            var deleteId = _educationService.Delete(id);
            return Ok(GetResponse(deleteId));
        }
    }
}
