namespace VibeHive.Client.WinForms.Dtos
{
    public class EventView
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public DateTime Date { get; set; }
        public string Venue { get; set; } = "";
        public string Genre { get; set; } = "";
        public int AvailableTickets { get; set; }
    }
}