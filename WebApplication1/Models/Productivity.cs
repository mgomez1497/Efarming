using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebApplication1.Models
{
    public class Productivity
    {
        [Key]
        public Guid Id { get; set; }

        
        [StringLength(20)]
        public string TotalHectares { get; set; }

        
        [StringLength(20)]
        public string ForestProtectedHectares { get; set; }

        
        [StringLength(20)]
        public string ConservationHectares { get; set; }

        
        [StringLength(20)]
        public string ShadingPercentage { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        
        [StringLength(20)]
        public string InfrastructureHectares { get; set; }
        public DateTime? DeletedAt { get; set; }

        
        [Column(TypeName = "float")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double AverageAge { get; set; } = 0;

        [StringLength(20)]
        public string AverageDensity { get; set; }

        
        [Column(TypeName = "float")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double PercentageColombia { get; set; } = 0;

        
        [Column(TypeName = "float")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double PercentageCaturra { get; set; } = 0;

        
        [Column(TypeName = "float")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double PercentageCastillo { get; set; } = 0;

        
        [Column(TypeName = "float")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double PercentageOtra { get; set; } = 0;

        [StringLength(20)]
        public string CoffeeArea { get; set; }

       
        [Column(TypeName = "float")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double ProductionPlants { get; set; } = 0;

        
        [Column(TypeName = "float")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double ProductionPercentage { get; set; } = 0;

        
        [Column(TypeName = "float")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double GrowingPlants { get; set; } = 0;

        
        [Column(TypeName = "float")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double GrowingPercentage { get; set; } = 0;

        
        [Column(TypeName = "float")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double EstimatedProduction { get; set; } = 0;

        
        [Column(TypeName = "float")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double ProductionAreaPercentage { get; set; } = 0;

        
        [Column(TypeName = "float")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double GrowingAreaPercentage { get; set; } = 0;

        [StringLength(20)]
        public string ProductionArea { get; set; }

        [StringLength(20)]
        public string GrowingArea { get; set; }

        public virtual ICollection<Plantation> Plantations { get; set; } = new List<Plantation>();

        
    }

}
