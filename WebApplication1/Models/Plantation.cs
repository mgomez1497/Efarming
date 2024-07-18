using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Plantation
    {
        public Guid Id { get; set; }

        public string Hectares { get; set; }

        public string EstimatedProduction { get; set; }

        public DateTime? Age { get; set; }

        public int NumberOfPlants { get; set; }

        public Guid? PlantationStatusId { get; set; }

        public Guid? ProductivityId { get; set; }

        public Guid? PlantationTypeId { get; set; }

        public Guid? PlantationVarietyId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public string TreesDistance { get; set; }

        public string GrooveDistance { get; set; }

        public string Density { get; set; }

        public int NumberLot { get; set; }

        public string NomLot { get; set; }

        public string LabLot { get; set; }

        public string TipoLot { get; set; }

        public string FormLot { get; set; }

        public int NumEjeArbLot { get; set; }

        
    }
}