using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrooveApi.Models
{
    public class Ticket
    {
        public string Assigned_Group { get; set; }
        public DateTime Created_At { get; set; }
        public int Number { get; set; }
        public TicketPriority? Priority { get; set; }
        public DateTime? Resolution_Time { get; set; }
        public string Title { get; set; }
        public DateTime Updated_At { get; set; }
        public string Href { get; set; }
        public string Closed_By { get; set; }
        public List<string> Tags { get; set; }
        public int Message_Count { get; set; }
        public string Summary { get; set; }
        public List<TicketLink> Links { get; set; }
    }
}
