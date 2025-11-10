using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VibeHive.EventsApi.Dtos;
using VibeHive.EventsApi.Models;

namespace VibeHive.EventsApi.Controllers;

[ApiController, Route("api/events")]
public class EventsController(AppDb db) : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(db.Events.OrderBy(e => e.Date).ToList());

    [Authorize(Policy = "AdminOrManager")]
    [HttpPost]
    public IActionResult Create(CreateEventDto dto)
    {
        var ev = new Event { Name = dto.Name, Date = dto.Date, Venue = dto.Venue, Genre = dto.Genre, AvailableTickets = dto.AvailableTickets };
        db.Events.Add(ev); db.SaveChanges();
        return Created($"/api/events/{ev.Id}", ev);
    }
}