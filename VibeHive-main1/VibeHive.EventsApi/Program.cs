using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using VibeHive.EventsApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDb>(o => o.UseInMemoryDatabase("events-db"));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var jwt = builder.Configuration.GetSection("Jwt");
var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt["SecretKey"]!));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(o => o.TokenValidationParameters = new()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwt["Issuer"],
        ValidAudience = jwt["Audience"],
        IssuerSigningKey = key
    });

builder.Services.AddAuthorization(opt =>
{
    opt.AddPolicy("AdminOrManager", p => p.RequireRole(Roles.Admin, Roles.EventManager));
});

var app = builder.Build();

// Seed demo admin + sample event
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDb>();
    if (!db.Users.Any())
    {
        db.Users.Add(new User { Name = "Admin", Email = "admin@local", Password = "admin", Role = Roles.Admin });
        db.Events.Add(new Event { Name = "Jazz Night", Date = DateTime.UtcNow.AddDays(7), Venue = "Main Hall", Genre = "Jazz", AvailableTickets = 100 });
        db.SaveChanges();
    }
}

app.MapGet("/health", () => Results.Ok(new { status = "ok" }));

if (app.Environment.IsDevelopment()) { app.UseSwagger(); app.UseSwaggerUI(); }

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();