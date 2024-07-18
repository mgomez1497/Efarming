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
    public class ProductivityController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        [Route("api/Productivity")]

        public IHttpActionResult GetProductivity(string Id)
        {
            var productivity = db.Productivity.Where(p => p.Id.ToString().Equals (Id))
            .Select(p => new
            {
                p.CoffeeArea,
                p.InfrastructureHectares,
                p.ConservationHectares,
                p.TotalHectares

            }).ToList();

            return Ok(productivity);

        }


        [HttpPut]
        [Route("api/Productivity/PutProductivity/{id}")]

        public IHttpActionResult PutProductivity(Guid Id,Productivity productivity) 
        {
            try
            {
                var productivities = db.Productivity.Where(p => p.Id == Id);

                if (productivities.Any())
                {
                    var Exproductivity = productivities.FirstOrDefault();

                    if (Exproductivity != null)
                    {
                        Exproductivity.CoffeeArea = productivity.CoffeeArea;
                        Exproductivity.InfrastructureHectares = productivity.InfrastructureHectares;
                        Exproductivity.ConservationHectares = productivity.ConservationHectares;
                        Exproductivity.TotalHectares = productivity.TotalHectares;

                        db.SaveChanges();

                        return Ok(productivity);
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();

        }

    }
}
