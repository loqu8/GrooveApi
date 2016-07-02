using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrooveApi.Models
{
    public class Customer
    {
        public string email { get; set; }
        public string name { get; set; }
        public string about { get; set; }
        public string TwitterUsername { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string LinkedInUsername { get; set; }
    }
}
