using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Domain.Models
{
    public class Workers
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Organization { get; set; }
        public string Role { get; set; }
        public int OrganizationId { get; set; }
        public string Address { get; set; }
        public string UserToken { get; set; }
        public bool IsAccepted { get; set; } = false;
    }
}
