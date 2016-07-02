using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class Settings
    {
        public static readonly string Token = Environment.GetEnvironmentVariable("GrooveToken");
    }
}
