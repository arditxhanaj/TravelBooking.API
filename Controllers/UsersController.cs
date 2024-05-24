using Microsoft.AspNetCore.Mvc;
using TravelBooking.API.Dto;
using TravelBooking.API.Models;
using System.Collections.Generic;

namespace TravelBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com" },
            new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" }
        };

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(users);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] PostUserDto payload)
        {
            var newUser = new User
            {
                Id = users.Count + 1,
                Name = payload.Name,
                Email = payload.Email
            };

            users.Add(newUser);
            return Ok(newUser);
        }
    }
}
