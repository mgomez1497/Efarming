using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Supplier
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null;

        public Guid CountryId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public string LogoUrl { get; set; }

        public virtual Country Country { get; set; } = null;

        public virtual ICollection<SupplyChain> SupplyChains { get; set; } = new List<SupplyChain>();
    }
}