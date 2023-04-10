﻿using CVBuilder.Core.Dto;
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
        {
            var category = _userService.Get(id);
            return Ok(GetResponse(category));
        }

        [HttpPost]
        public IActionResult Create([FromForm] CreateUserDto dto)
        {
            var savedId = _userService.Create(dto);
            return Ok(GetResponse(savedId));
        }

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
