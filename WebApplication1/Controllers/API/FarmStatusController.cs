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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FarmStatusController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        [Route("api/FarmStatus")]
        
        public IHttpActionResult GetFarmStatus()
        {
            var farmStatus = db.FarmStatus.Select(fs => new
            {
               fs.Id,
               fs.Name,
               fs.CreatedAt,
               fs.UpdatedAt,
               fs.DeletedAt
            }
            ).ToList();

            return Ok(farmStatus);
        }

    }
}
