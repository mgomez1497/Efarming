using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication1.Models
{
    // Para agregar datos de perfil del usuario, agregue más propiedades a su clase ApplicationUser. Visite https://go.microsoft.com/fwlink/?LinkID=317594 para obtener más información.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que authenticationType debe coincidir con el valor definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            
    
            // Agregar reclamaciones de usuario personalizadas aquí
            return userIdentity;
        }

        public virtual ICollection<Farm> FarmUser { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<WebApplication1.Models.Farm> Farms { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Cooperative> Cooperatives { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.FarmStatus> FarmStatus { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.FarmSubstatus> FarmSubstatus { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.OwnershipType> OwnershipTypes { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.SupplyChain> SupplyChains { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Village> Villages { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.FarmAssociatedPeople> AssociatedPeople { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.FamilyUnitMembers> FamilyUnitMembers { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Productivity> Productivity { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.PlantationTypes> PlantationTypes { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.PlantationStatuses> PlantationStatuses { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.PlantationVarieties> PlantationVarieties { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Plantation> Plantation { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.SustainabilityContacts> SustainabilityContacts { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.SustainabilityContactFarm> SustainabilityContactFarm { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.SustainabilityContactsLocations> SustainabilityContactsLocations { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.SustainabilityContactsTypes> SustainabilityContactsTypes { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.SustainabilityContactTopic> SustainabilityContactTopic { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.SustainabilityContactTopics> SustainabilityContactTopics { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configurar el nombre de la tabla Plantation
            modelBuilder.Entity<Plantation>().ToTable("Plantation");
            base.OnModelCreating(modelBuilder);
        }

    }
}