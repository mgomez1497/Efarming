using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SupplyChain
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null;

        public Guid SupplierId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public Guid? QualityProfileId { get; set; }

        public Guid? SupplyChainStatusId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double Potencial { get; set; }

        public double Bags { get; set; }

        public Guid DepartmentId { get; set; }

        public int Code { get; set; }

        public string Address { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Farm> Farms { get; set; } = new List<Farm>();

        public virtual QualityProfile QualityProfile { get; set; }

        public virtual Supplier Supplier { get; set; } = null;

        public virtual SupplyChainStatus SupplyChainStatus { get; set; }
    }
}