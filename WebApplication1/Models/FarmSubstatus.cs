using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class FarmSubstatus
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null;

        public Guid FarmStatusId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public virtual FarmStatus FarmStatus { get; set; } = null;

        public virtual ICollection<Farm> Farms { get; set; } = new List<Farm>();
    }
}