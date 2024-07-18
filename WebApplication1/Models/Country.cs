using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Country
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null;

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public int Code { get; set; }

        public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
    }
}