namespace TravelBooking.API.Dto
{
    public class PostBookingDto
    {
        public int DestinationId { get; set; }
        public int UserId { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfPeople { get; set; }
    }
}