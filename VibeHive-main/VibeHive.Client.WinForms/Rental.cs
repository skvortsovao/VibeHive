namespace VibeHive
{
    public class Rental
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public int AlbumId { get; set; }
        public DateTime RentalTime { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
