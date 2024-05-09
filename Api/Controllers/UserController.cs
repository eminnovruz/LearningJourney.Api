﻿using Application.Models.Responses;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAlLBooks")]
        public ActionResult<BookInfo> GetAllBooks()
        {
            try
            {
                return Ok(_userService.GetAllBooks());
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
