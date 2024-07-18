using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Municipality
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null;

        public Guid DepartmentId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public int Code { get; set; }

        public virtual Department Department { get; set; } = null;

        public virtual ICollection<Village> Villages { get; set; } = new List<Village>();
    }
}