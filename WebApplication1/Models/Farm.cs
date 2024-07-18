using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Farm
    {
        public string Name { get; set; } = null;

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public Guid Id { get; set; }

        public string Code { get; set; } = null;

        public Guid VillageId { get; set; }

        public DbGeography Geolocation { get; set; }

        public Guid? FarmSubstatusId { get; set; }

        public Guid? CooperativeId { get; set; }

        public Guid? OwnershipTypeId { get; set; }

        public DateTime? DeletedAt { get; set; }

        public Guid? SupplyChainId { get; set; }

        public Guid? FarmStatusId { get; set; }



        public virtual Cooperative Cooperative { get; set; }

        public virtual FarmStatus FarmStatus { get; set; }

        public virtual FarmSubstatus FarmSubstatus { get; set; }

        //public virtual ICollection<Fertilizer> Fertilizers { get; set; } = new List<Fertilizer>();

        //public virtual ICollection<Image> Images { get; set; } = new List<Image>();

        //public virtual ICollection<ImpactAssessment> ImpactAssessments { get; set; } = new List<ImpactAssessment>();


        public virtual OwnershipType OwnershipType { get; set; }

        public virtual SupplyChain SupplyChain { get; set; }

        public virtual Village Village { get; set; } = null;

        public ICollection<FarmAssociatedPeople> FarmAssociatedPeople { get; set;}

        //public virtual Worker? Worker { get; set; }

        public virtual ICollection<SustainabilityContactFarm> Contacts { get; set; } = new List<SustainabilityContactFarm>();

        //public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

        //public virtual ICollection<SoilType> SoilTypes { get; set; } = new List<SoilType>();

        //public virtual ICollection<User> Users { get; set; } = new List<User>();

        public virtual ICollection<ApplicationUser> Users { get; set; }

        //public virtual Productivity Productivity { get; set; }

        public virtual ICollection<FamilyUnitMembers> FamilyUnitMembers { get; set; }

    }


}