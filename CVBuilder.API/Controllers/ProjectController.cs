using CVBuilder.Core.Dto;
using CVBuilder.Infostructure.Services.EducationService;
using CVBuilder.Infostructure.Services.ProjectService;
using Microsoft.AspNetCore.Mvc;

namespace CVBuilder.API.Controllers
{
    public class ProjectController : BaseController
    {
        private readonly IProjectService _educationService;

        public ProjectController(IProjectService educationService)
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
        public IActionResult Create([FromBody] List<CreateProjectDto> dto, string UserId)
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
