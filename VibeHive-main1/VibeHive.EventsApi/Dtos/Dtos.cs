namespace VibeHive.EventsApi.Dtos;
public record RegisterDto(string Name, string Email, string Password, string Role);
public record LoginDto(string Email, string Password);
public record CreateEventDto(string Name, DateTime Date, string Venue, string Genre, int AvailableTickets);
public record BookTicketDto(int EventId, int UserId);