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
    public class OwnershipTypesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        [Route("api/OwnershipTypes")]
        // GET: OwnershipTypes
        public IHttpActionResult GetOwnership() 
        {
            var Ownership = db.OwnershipTypes.Select(O => new
            {
                O.Id,
                O.Name,
                O.CreatedAt,
                O.UpdatedAt,
                O.DeletedAt
            }
            ).ToList();

            return Ok(Ownership);
        }

    }
}
