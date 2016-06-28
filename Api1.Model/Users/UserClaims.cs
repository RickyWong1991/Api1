using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api0.Models
{
    public class UserClaims
    {
        public string ID { get; set; }
        public string User { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}
