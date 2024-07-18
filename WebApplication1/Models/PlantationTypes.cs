using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PlantationTypes
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null;

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<PlantationVarieties> PlantationVarieties { get; set; } = new List<PlantationVarieties>();


    }
}