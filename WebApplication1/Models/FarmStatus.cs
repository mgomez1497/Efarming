using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class FarmStatus
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null;

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<FarmSubstatus> FarmSubstatuses { get; set; } = new List<FarmSubstatus>();

        public virtual ICollection<Farm> Farms { get; set; } = new List<Farm>();
    }
}