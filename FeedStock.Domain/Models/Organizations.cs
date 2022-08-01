using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Domain.Models
{
    public class Organizations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RelatedRole { get; set; }
        public string RelatedOrganization { get; set; }
        public string OrganizationTopic { get; set; }
    }
}
