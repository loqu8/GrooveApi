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

        public string Body { get; set; }           // required
        public string Assigned_Group { get; set; }
        public string Assignee { get; set; }
        public DateTime Sent_At { get; set; }
        public bool Note { get; set; }
        public bool Send_Copy_To_Customer { get; set; }
        public TicketState State { get; set; }
        public string Subject { get; set; }

        // Customer attributes
        public string Email { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Twitter_Username { get; set; }
        public string Title { get; set; }
        public string Company_Name { get; set; }
        public string Phone_Number { get; set; }
        public string Location { get; set; }
        public string LinkedIn_Username { get; set; }

        private string getAttributesHash()
        {
            var target = string.Concat(Email, Name, About, Twitter_Username, Title, Company_Name, Location, LinkedIn_Username);
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
