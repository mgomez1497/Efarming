using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Net;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using System.Web.Http.Description;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PlantationsVarietyController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        [Route("api/PlantationsVariety")]
        public IHttpActionResult getPlantationsVariety()
        {
            var PlantationsVariety = db.PlantationVarieties.Select(pv => new
            {
                pv.Id,
                pv.Name,
                pv.CreatedAt,
                pv.UpdatedAt,
                pv.DeletedAt,
                pv.PlantationTypes_Id,
            }).ToList();

            return Ok(PlantationsVariety);
        }
    }
}
