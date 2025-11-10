namespace VibeHive.EventsApi.Models;
public class Event
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public DateTime Date { get; set; }
    public string Venue { get; set; } = "";
    public string Genre { get; set; } = "";
    public int AvailableTickets { get; set; }
}