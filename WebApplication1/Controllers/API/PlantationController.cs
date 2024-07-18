using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;

using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using WebApplication1.Models;

namespace WebApplication1.Controllers.API
{
    public class PlantationController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        [Route("api/Plantations")]
        public IHttpActionResult getPlantationVariety(string productivityId)
        {
            var plantations = db.Plantation.Where(p => p.ProductivityId.ToString() == (productivityId))
                .Select(p => new
                {
                    p.Id,
                    p.Hectares,
                    p.EstimatedProduction,
                    p.Age,
                    p.NumberOfPlants,
                    p.ProductivityId,
                    p.CreatedAt,
                    p.UpdatedAt,
                    p.DeletedAt,
                    p.TreesDistance,
                    p.GrooveDistance,
                    p.Density,
                    p.NumberLot,
                    p.NomLot,
                    p.LabLot,
                    p.TipoLot,
                    p.FormLot,
                    p.NumEjeArbLot,
                    p.PlantationTypeId,
                    p.PlantationStatusId,
                    p.PlantationVarietyId
                }).ToList();
            return Ok(plantations);
        }

        [HttpPut]
        [Route("api/Farms/PutPlantations/{id}")]

        public IHttpActionResult PutPlantations(Guid id, Plantation plant)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var plants = db.Plantation.Where(p => p.Id == id);

                if (plants.Any())
                {
                    var ExistingPlants = plants.FirstOrDefault();

                    if (ExistingPlants != null)
                    {
                        ExistingPlants.Hectares = plant.Hectares;
                        ExistingPlants.EstimatedProduction = plant.EstimatedProduction;
                        ExistingPlants.Age = plant.Age;
                        ExistingPlants.NumberOfPlants = plant.NumberOfPlants;
                        ExistingPlants.ProductivityId = plant.ProductivityId;
                        ExistingPlants.UpdatedAt = plant.UpdatedAt;
                        ExistingPlants.TreesDistance = plant.TreesDistance;
                        ExistingPlants.GrooveDistance = plant.GrooveDistance;
                        ExistingPlants.Density = plant.Density;
                        ExistingPlants.NumberLot = plant.NumberLot;
                        ExistingPlants.NomLot = plant.NomLot;
                        ExistingPlants.LabLot = plant.LabLot;
                        ExistingPlants.TipoLot = plant.TipoLot;
                        ExistingPlants.FormLot = plant.FormLot;
                        ExistingPlants.NumEjeArbLot = plant.NumberLot;
                        ExistingPlants.PlantationTypeId = plant.PlantationTypeId;
                        ExistingPlants.PlantationStatusId = plant.PlantationStatusId;
                        ExistingPlants.PlantationVarietyId = plant.PlantationVarietyId;

                        db.SaveChanges();
                        return Ok();
                    }
                }

                else
                {
                    var newPlant = new Plantation
                    {
                        Id = plant.Id,
                        Hectares = plant.Hectares,
                        EstimatedProduction = plant.EstimatedProduction,
                        Age = plant.Age,
                        NumberOfPlants = plant.NumberOfPlants,
                        ProductivityId = plant.ProductivityId,
                        CreatedAt = plant.CreatedAt,
                        UpdatedAt = plant.UpdatedAt,
                        DeletedAt = plant.DeletedAt,
                        TreesDistance = plant.TreesDistance,
                        GrooveDistance = plant.GrooveDistance,
                        Density = plant.Density,
                        NumberLot = plant.NumberLot,
                        NomLot = plant.NomLot,
                        LabLot = plant.LabLot,
                        TipoLot = plant.TipoLot,
                        FormLot = plant.FormLot,
                        NumEjeArbLot = plant.NumEjeArbLot,
                        PlantationTypeId = plant.PlantationTypeId,
                        PlantationStatusId = plant.PlantationStatusId,
                        PlantationVarietyId = plant.PlantationVarietyId,
                        
                    };

                    db.Plantation.Add(newPlant);
                    db.SaveChanges();
                    return Ok();

                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
            return Ok();



        }
    }
}
