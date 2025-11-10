namespace VibeHive.Client.WinForms.Dtos
{
    public class LoginResponse
    {
        public string token { get; set; } = "";
        public int id { get; set; }
        public string name { get; set; } = "";
        public string email { get; set; } = "";
        public string role { get; set; } = "";
    }
}