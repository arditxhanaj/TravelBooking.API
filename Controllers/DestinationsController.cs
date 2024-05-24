using Microsoft.AspNetCore.Mvc;
using TravelBooking.API.Models;

namespace TravelBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDestinations()
        {
            var destinations = new List<Destination>
            {
                new Destination { Id = 1, Name = "Paris", Country = "France", Description = "City of Light" },
                new Destination { Id = 2, Name = "Tokyo", Country = "Japan", Description = "Land of the Rising Sun" },
                new Destination { Id = 3, Name = "New York", Country = "USA", Description = "The Big Apple" }
            };

            return Ok(destinations);
        }

        [HttpPost]
        public IActionResult AddDestination([FromBody] Destination destination)
        {
            // Add logic to save the destination
            return Ok(destination);
        }
    }
}
