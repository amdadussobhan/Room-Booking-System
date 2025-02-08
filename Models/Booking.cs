namespace Room_Booking_System.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Foreign key to Room
        public int RoomId { get; set; }
        public Room? Room { get; set; }

        // Foreign key to User
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
