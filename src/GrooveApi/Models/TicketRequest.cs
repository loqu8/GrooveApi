using PCLCrypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace GrooveApi.Models
{
    public class TicketRequest
    {
        public string To { get; set; }
        public Customer From { get; set; }
        public string Body { get; set; }           // required
        public string AssignedGroup { get; set; }
        public string Assignee { get; set; }
        public DateTime? SentAt { get; set; }
        public bool Note { get; set; }
        public bool SendCopyToCustomer { get; set; }
        public TicketState State { get; set; }
        public string Subject { get; set; }
    }
}
