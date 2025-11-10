using Microsoft.AspNetCore.Mvc;
using VibeHive.EventsApi.Dtos;
using VibeHive.EventsApi.Models;

namespace VibeHive.EventsApi.Controllers;

[ApiController, Route("api/users")]
public class UsersController(AppDb db) : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register(RegisterDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Name))
            return BadRequest("Name is required.");

        if (string.IsNullOrWhiteSpace(dto.Email))
            return BadRequest("Email is required.");

        if (string.IsNullOrWhiteSpace(dto.Password))
            return BadRequest("Password is required.");

        var allowedRoles = new[] { "User", "Admin", "EventManager" };
        var role = string.IsNullOrWhiteSpace(dto.Role) ? "User" : dto.Role.Trim();
        if (!allowedRoles.Contains(role, StringComparer.OrdinalIgnoreCase))
            return BadRequest("Role must be User, Admin, or EventManager.");

        if (db.Users.Any(u => u.Email == dto.Email)) //prevent duplicate
            return Conflict("Email is already registered.");

        var user = new User
        {
            Name = dto.Name.Trim(),
            Email = dto.Email.Trim(),
            Password = dto.Password, // no hashing
            Role = allowedRoles.First(r => r.Equals(role, StringComparison.OrdinalIgnoreCase))
        };

        db.Users.Add(user);
        db.SaveChanges();
        return Ok(user);
    }
}