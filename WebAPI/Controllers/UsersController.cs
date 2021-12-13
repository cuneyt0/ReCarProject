using Business.Abstract;
using Entities.Conctre;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUsersServices _usersService;

        public UsersController(IUsersServices usersService)
        {
            _usersService = usersService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _usersService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getuserbyid")]
        public IActionResult GetUsersById(int id)
        {
            var result = _usersService.GetUsersById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]

        public IActionResult Add(Users user)
        {
            var result = _usersService.Add(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]

        public IActionResult Delete(Users user)
        {
            var result = _usersService.Delete(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPatch("update")]
        public IActionResult Update(Users user)
        {
            var result = _usersService.Update(user);


            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

     
    }
}
