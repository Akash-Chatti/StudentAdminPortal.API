using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudenAdminPortal.API.DomainModels
{
    public class Student
    {
        public Guid ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string ProfileImageUrl { get; set; }

        public Guid GenderID { get; set; }

        //Nav Properties
        public Gender Gender { get; set; }
        public Address Address { get; set; }
    }
}
