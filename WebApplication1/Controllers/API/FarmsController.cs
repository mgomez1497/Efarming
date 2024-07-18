using System;
using System.Collections.Generic;
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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FarmsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Farms

        [HttpGet]
        [Route("api/Farms")]
        public IHttpActionResult GetFarms()
        {
            var farms = db.Farms.Select(f => new
            {
                f.Id,
                f.Name,
                f.Code,
                f.CooperativeId,
                f.SupplyChainId,
                f.OwnershipTypeId,
                f.FarmStatusId,
                f.CreatedAt,
                f.UpdatedAt,
                f.Geolocation
                
                
            }).ToList();

            return Ok(farms);
        }
        // GET: api/Farms/5
        [HttpGet]
        [Route("api/Farms/GetFarmsByUser")]
        public IHttpActionResult GetFarmByUser(string UserId)
        {
            
            var farmAssociated = db.AssociatedPeople.Where(A=> A.UserId == UserId).Select(A=> new
            {
                A.FarmId
            }).ToList();
                
            return Ok(farmAssociated);
        }

        [HttpGet]
        [Route("api/Farms/GetFarmsByCode")]

        public IHttpActionResult GetFarmByCode(string Code, string UserId)
        {
            var farm = db.Farms
               
                .Where(f => f.Code == Code && f.FarmAssociatedPeople.Any(u => u.UserId == UserId))
                .Select(f => new
                {
                    f.Id,
                    f.Name,
                    f.Code,
                    f.CooperativeId,
                    f.SupplyChainId,
                    f.OwnershipTypeId,
                    f.FarmStatusId,
                    f.VillageId,
                    f.CreatedAt,
                    f.UpdatedAt,
                    f.DeletedAt,
                    f.FarmSubstatusId,
                    f.Geolocation
                })
                .ToList();

            if (farm == null || farm.Count == 0)
            {
                return NotFound();
            }

            return Ok(farm);
        }

        [HttpGet]
        [Route("api/Farms/GetFarmsByVillage")]
        public IHttpActionResult GetFarmByVillage(string VillageId, string UserId)
        {
            var farm = db.Farms

                .Where(f => f.VillageId.ToString() == VillageId && f.FarmAssociatedPeople.Any(u => u.UserId == UserId))
                .Select(f => new
                {
                    f.Id,
                    f.Name,
                    f.Code,
                    f.CooperativeId,
                    f.SupplyChainId,
                    f.OwnershipTypeId,
                    f.FarmStatusId,
                    f.VillageId,
                    f.CreatedAt,
                    f.UpdatedAt,
                    f.DeletedAt,
                    f.FarmSubstatusId,
                    f.Geolocation
                })
                .ToList();

            if (farm == null || farm.Count == 0)
            {
                return NotFound();
            }

            return Ok(farm);
        }

        [HttpPut]
        [Route("api/Farms/PutFarms/{id}")]
        public IHttpActionResult PutFarm(Guid id, Farm farm)
        {
           
            if (id != farm.Id)
            {
                return BadRequest("");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                
                var farms = db.Farms.Where(f => f.Id == id);


                if (farms.Any())
                {

                    var existingFarm = farms.FirstOrDefault();


                    if (existingFarm != null)
                    {

                        existingFarm.Name = farm.Name;
                        existingFarm.Code = farm.Code;
                        existingFarm.CooperativeId= farm.CooperativeId;
                        existingFarm.VillageId= farm.VillageId;
                        existingFarm.FarmStatusId= farm.FarmStatusId;
                        existingFarm.OwnershipTypeId= farm.OwnershipTypeId;
                        existingFarm.SupplyChainId= farm.SupplyChainId;
                        existingFarm.UpdatedAt= farm.UpdatedAt;
                        existingFarm.Geolocation= farm.Geolocation;



                        db.SaveChanges();

                        return Ok();
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir
                return InternalServerError(ex);
            }
            return Ok();
        }



        // POST: api/Farms
        [ResponseType(typeof(Farm))]
        public IHttpActionResult PostFarm(Farm farm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Farms.Add(farm);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (FarmExists(farm.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = farm.Id }, farm);
        }

        // DELETE: api/Farms1/5
        [ResponseType(typeof(Farm))]
        public IHttpActionResult DeleteFarm(Guid id)
        {
            Farm farm = db.Farms.Find(id);
            if (farm == null)
            {
                return NotFound();
            }

            db.Farms.Remove(farm);
            db.SaveChanges();

            return Ok(farm);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FarmExists(Guid id)
        {
            return db.Farms.Count(e => e.Id == id) > 0;
        }
    }
}