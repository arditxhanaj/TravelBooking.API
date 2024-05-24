using Microsoft.AspNetCore.Mvc;
using TravelBooking.API.Dto;
using TravelBooking.API.Models;

namespace TravelBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBookings()
        {
            var bookings = new List<Booking>
            {
                new Booking { Id = 1, DestinationId = 1, UserId = 1, BookingDate = DateTime.Now, NumberOfPeople = 2 }
            };

            return Ok(bookings);
        }

        [HttpPost]
        public IActionResult AddBooking([FromBody] PostBookingDto payload)
        {
            var booking = new Booking
            {
                DestinationId = payload.DestinationId,
                UserId = payload.UserId,
                BookingDate = payload.BookingDate,
                NumberOfPeople = payload.NumberOfPeople
            };

            // Add logic to save the booking
            return Ok(booking);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBooking(int id, [FromBody] PutBookingDto payload)
        {
            // Add logic to update the booking
            return Ok(payload);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            // Add logic to delete the booking
            return Ok();
        }
    }
}
