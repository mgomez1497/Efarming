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

namespace WebApplication1.Controllers.API
{
    public class PlantationStatusController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        [Route("api/PlantationStatus")]

        public IHttpActionResult getPlantationStatus()
        {
            var PlantationStatus = db.PlantationStatuses.Select(Ps => new
            {
                Ps.Id,
                Ps.Name,
                Ps.CreatedAt,
                Ps.UpdatedAt,
                Ps.DeletedAt


            }).ToList();

            return Ok(PlantationStatus);
        }
    }
}
