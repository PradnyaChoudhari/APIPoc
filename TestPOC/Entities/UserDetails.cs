using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPOC.Entities
{
    public class UserDetails
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
    }
}
