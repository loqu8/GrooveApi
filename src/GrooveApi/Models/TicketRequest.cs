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
        private string _from;

        [AliasAs("from")]
        public string From {
            get {
                var result = string.IsNullOrEmpty(_from) ? getAttributesHash() : _from;
                return result;
            }
            set
            {
                if (_from == value) return;
                _from = value;
            }
        }

        private string _to;

        [AliasAs("to")]
        public string To
        {
            get {
                var result = string.IsNullOrEmpty(_to) ? getAttributesHash() : _to;
                return result;
            }
            set
            {
                if (_to == value) return;
                _to = value;
            }
        }

        [AliasAs("body")]
        public string Body { get; set; }           // required
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
        public string Subject { get; set; }

        // Customer attributes
        [AliasAs("email")]
        public string Email { get; set; }
        [AliasAs("first_name")]
        public string FirstName { get; set; }
        [AliasAs("last_name")]
        public string LastName { get; set; }
        [AliasAs("about")]
        public string About { get; set; }
        [AliasAs("twitter_username")]
        public string TwitterUsername { get; set; }
        [AliasAs("title")]
        public string Title { get; set; }
        [AliasAs("company_name")]
        public string CompanyName { get; set; }
        [AliasAs("phone_number")]
        public string PhoneNumber { get; set; }
        [AliasAs("location")]
        public string Location { get; set; }
        [AliasAs("linkedIn_username")]
        public string LinkedInUsername { get; set; }

        private string getAttributesHash()
        {
            var target = string.Concat(Email, FirstName, LastName, About, TwitterUsername, Title, CompanyName, Location, LinkedInUsername);
            return CalculateSha1Hash(target);
        }

        // http://stackoverflow.com/questions/10254369/generate-sha1-hash-in-portable-class-library
        private static string CalculateSha1Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            var hasher = WinRTCrypto.HashAlgorithmProvider.OpenAlgorithm(HashAlgorithm.Sha1);
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = hasher.HashData(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
