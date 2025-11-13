namespace VibeHive.EventsApi.Models;
public class Ticket
{
    public int Id { get; set; }
    public int EventId { get; set; }
    public int UserId { get; set; }
    public string Status { get; set; } = "Booked"; 
}