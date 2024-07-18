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
    public class PlantationTypesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        [Route("api/PlantationTypes")]
        public IHttpActionResult getPlantationTypes()
        {
            var PlantationTypes = db.PlantationTypes.Select(Pt => new
            {
                Pt.Id,
                Pt.Name,
                Pt.CreatedAt,
                Pt.UpdatedAt,
                Pt.DeletedAt


            }).ToList();

            return Ok(PlantationTypes);
        }
    }
}
