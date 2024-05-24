using Microsoft.AspNetCore.Mvc;

namespace TravelBooking.API.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int DestinationId { get; set; }
        public int UserId { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfPeople { get; set; }
    }
}