using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudenAdminPortal.API.DomainModels
{
    public class Address
    {
        public Guid ID { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }
        // Nav prop
        public Guid StudentId { get; set; }
    }
}
