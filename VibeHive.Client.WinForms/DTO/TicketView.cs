using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VibeHive.Client.WinForms.DTO
{
    public class TicketView
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string Event { get; set; } = "";
        public DateTime Date { get; set; }
        public string Venue { get; set; } = "";
        public string Status { get; set; } = "";
    }
}
