namespace Room_Booking_System.Models
{
    public class Room
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
    }
}
