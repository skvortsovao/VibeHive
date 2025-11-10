using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VibeHive.EventsApi.Dtos;
using VibeHive.EventsApi.Models;

namespace VibeHive.EventsApi.Controllers;

[ApiController]
[Route("api/tickets")]
public class TicketsController : ControllerBase
{
    private readonly AppDb _db;
    public TicketsController(AppDb db) => _db = db;

    //to book tickets
    [Authorize]
    [HttpPost]
    public IActionResult Book(BookTicketDto dto)
    {
        var ev = _db.Events.Find(dto.EventId);
        if (ev is null) return NotFound("Event not found.");
        if (ev.AvailableTickets <= 0) return BadRequest("No tickets available.");

        var t = new Ticket { EventId = dto.EventId, UserId = dto.UserId, Status = "Booked" };
        _db.Tickets.Add(t);
        ev.AvailableTickets--;
        _db.SaveChanges();
        return Ok(t);
    }

    //to see all my tickets
    [Authorize]
    [HttpGet("{userId:int}")]
    public IActionResult ForUser(int userId) =>
        Ok(_db.Tickets.Where(t => t.UserId == userId).ToList());

    // user can cancel his own ticket
    [Authorize]
    [HttpPost("{ticketId:int}/cancel")]
    public IActionResult Cancel(int ticketId)
    {
        var t = _db.Tickets.Find(ticketId);
        if (t is null) return NotFound("Ticket not found.");

        var callerIdStr = User.FindFirst(ClaimTypes.NameIdentifier)?.Value
                          ?? User.FindFirst(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Sub)?.Value;
        _ = int.TryParse(callerIdStr, out var callerId);
        var role = User.FindFirst(ClaimTypes.Role)?.Value ?? "User";

        var isOwner = t.UserId == callerId;
        var isPrivileged = role is "Admin" or "EventManager";
        if (!isOwner && !isPrivileged) return Forbid();

        if (!string.Equals(t.Status, "Booked", StringComparison.OrdinalIgnoreCase))
            return BadRequest("Ticket is not currently 'Booked'.");

        var ev = _db.Events.Find(t.EventId);
        if (ev is null) return NotFound("Event not found for ticket.");

        t.Status = "Cancelled";
        ev.AvailableTickets++;
        _db.SaveChanges();

        return Ok(new { message = "Ticket cancelled.", ticketId = t.Id, ev.AvailableTickets });
    }

    // for admin and event manager to see all tickets
    [Authorize(Roles = "Admin,EventManager")]
    [HttpGet]
    public IActionResult All() => Ok(_db.Tickets.ToList());

    //for admin and event manager to adjust tickets that are booked by users
    public record SetStatusDto(string Status);

    [Authorize(Roles = "Admin,EventManager")]
    [HttpPost("{id:int}/set-status")]
    public IActionResult SetStatus(int id, SetStatusDto dto)
    {
        var t = _db.Tickets.Find(id);
        if (t is null) return NotFound("Ticket not found.");
        var ev = _db.Events.Find(t.EventId);
        if (ev is null) return NotFound("Event not found for ticket.");

        var newStatus = dto.Status?.Trim();
        if (newStatus is not "Booked" and not "Cancelled")
            return BadRequest("Status must be 'Booked' or 'Cancelled'.");

        if (t.Status == "Booked" && newStatus == "Cancelled") ev.AvailableTickets++;
        else if (t.Status == "Cancelled" && newStatus == "Booked")
        {
            if (ev.AvailableTickets <= 0) return BadRequest("No tickets available to re-book.");
            ev.AvailableTickets--;
        }

        t.Status = newStatus;
        _db.SaveChanges();
        return Ok(t);
    }
}