using CVBuilder.Core.Dto;
using CVBuilder.Data.Models;
using CVBuilder.Infostructure.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace CVBuilder.API.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult GetAll(string serachkey)
        {
            var categories = _userService.GetAll(serachkey);
            return Ok(GetResponse(categories));
        }

        [HttpGet]
        public IActionResult Get(string id) 
            => Ok(GetResponse( _userService.Get(id)));
        

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateUserDto dto)
            => Ok(GetResponse(await _userService.Create(dto)));

        [HttpPut]
        public IActionResult Update([FromForm]UpdateUserDto dto)
        {
            var savedId = _userService.Update(dto);
            return Ok(GetResponse(savedId));
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            var deletedId = _userService.Delete(id);
            return Ok(GetResponse(deletedId));
        }
    }
}
