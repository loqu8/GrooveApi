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
        public string to { get; set; }
        public Customer from { get; set; }

        [AliasAs("body")]
        public string body { get; set; }           // required
        [AliasAs("assigned_group")]
        public string AssignedGroup { get; set; }
        [AliasAs("assignee")]
        public string Assignee { get; set; }
        [AliasAs("sent_at")]
        public DateTime? SentAt { get; set; }
        [AliasAs("note")]
        public bool Note { get; set; }
        [AliasAs("send_copy_to_customer")]
        public bool SendCopyToCustomer { get; set; }
        [AliasAs("state")]
        public TicketState State { get; set; }
        [AliasAs("subject")]
        public string subject { get; set; }
    }
}
