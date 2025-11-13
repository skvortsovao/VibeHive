namespace VibeHive.EventsApi.Models;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string Password { get; set; } = ""; 
    public string Role { get; set; } = "User";     
}
public static class Roles
{
    public const string User = "User";
    public const string Admin = "Admin";
    public const string EventManager = "EventManager";
}