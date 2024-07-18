using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PlantationVarieties
    {
        public Guid Id { get; set; }


        public string Name { get; set; } = null;

        public Guid? PlantationTypes_Id { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

       

    }
}