using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class FamilyUnitMembers
    {
        public Guid Id {  get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Age { get; set; }

        public String Identification { get; set; }

        public String Education { get; set; }

        public String PhoneNumber { get; set; }

        public String Relationship { get; set; }

        public String MaritalStatus { get; set; }

        public bool IsOwner { get; set; }

        public Guid FarmId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

       

    }
}