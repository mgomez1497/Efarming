using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Department
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null;

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public int? Code { get; set; }

        public virtual ICollection<Municipality> Municipalities { get; set; } = new List<Municipality>();

        public virtual ICollection<SupplyChain> SupplyChains { get; set; } = new List<SupplyChain>();
    }
}