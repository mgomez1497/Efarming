using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Plants
    {
        public Guid Id { get; set; }

        public string Hectares { get; set; }

        public string EstimatedProduction { get; set; }

        public DateTime? Age { get; set; }

        public int NumberOfPlants { get; set; }

        [ForeignKey("PlantationStatus")]
        public Guid? PlantationStatusId { get; set; }
        public virtual PlantationStatuses PlantationStatus { get; set; }
        [ForeignKey("Productivity")]
        public Guid? ProductivityId { get; set; }
        public virtual Productivity Productivity { get; set; }
        [ForeignKey("PlantationTypes")]
        public Guid? PlantationTypeId { get; set; }
        public virtual PlantationTypes PlantationTypes  { get; set; }

        [ForeignKey("PlantationVarieties")]
        public Guid? PlantationVarietyId { get; set; }
        public virtual PlantationVarieties PlantationVarieties { get; set; }

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