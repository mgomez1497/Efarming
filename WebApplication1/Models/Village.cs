using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Village
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null;

        public Guid MunicipalityId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public int Code { get; set; }

        public virtual ICollection<Farm> Farms { get; set; } = new List<Farm>();

       

        public virtual Municipality Municipality { get; set; } = null;

    }
}