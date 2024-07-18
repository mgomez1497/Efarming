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
    public class FamilyUnitMembersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        [Route("api/FamiliyUnitMembers/GetFUM")]

        public IHttpActionResult GetFUM(string FarmId)
        {
            var fum= db.FamilyUnitMembers.Where(fu=> fu.FarmId.ToString() == (FarmId))
                .Select(fu => new
                {
                    fu.Id,
                    fu.FirstName,
                    fu.LastName,
                    fu.Age,
                    fu.Identification,
                    fu.Education,
                    fu.PhoneNumber,
                    fu.Relationship,
                    fu.MaritalStatus, 
                    fu.IsOwner,
                    fu.FarmId, 
                    fu.CreatedAt, 
                    fu.UpdatedAt,
                    fu.DeletedAt
                }).ToList();

            return Ok(fum);
        }

        [HttpPut]
        [Route("api/Farms/PutFUM/{id}")]

        public IHttpActionResult PutFarm(Guid id , FamilyUnitMembers FUM)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var Fum = db.FamilyUnitMembers.Where(fu => fu.Id == id);

                if(Fum.Any())
                {
                    var existingFUM = Fum.FirstOrDefault();

                    if (existingFUM != null)
                    {
                        existingFUM.FirstName = FUM.FirstName;
                        existingFUM.LastName = FUM.LastName;
                        existingFUM.Age = FUM.Age;
                        existingFUM.Identification = FUM.Identification;
                        existingFUM.Education = FUM.Education;
                        existingFUM.PhoneNumber = FUM.PhoneNumber;
                        existingFUM.Relationship= FUM.Relationship;
                        existingFUM.MaritalStatus = FUM.MaritalStatus;
                        existingFUM.IsOwner = FUM.IsOwner;
                        existingFUM.FarmId= FUM.FarmId;
                        existingFUM.UpdatedAt = FUM.UpdatedAt;

                        db.SaveChanges();
                        return Ok();
                    }
                }

                else
                {
                    var newFum = new FamilyUnitMembers
                    {
                        Id = id,
                        FirstName = FUM.FirstName,
                        LastName = FUM.LastName,
                        Age = FUM.Age,
                        Identification = FUM.Identification,
                        Education = FUM.Education,
                        PhoneNumber = FUM.PhoneNumber,
                        Relationship = FUM.Relationship,
                        MaritalStatus = FUM.MaritalStatus,
                        IsOwner = FUM.IsOwner,
                        FarmId = FUM.FarmId,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = null,
                        DeletedAt = null

                    };
                    db.FamilyUnitMembers.Add(newFum);
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
