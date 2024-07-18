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
    public class ContactLocationsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        [Route("api/GetContactsLocations")]
        public IHttpActionResult getContactsLocations()
        {
            var Contactslocations = db.SustainabilityContactsLocations.Select(cl => new
            {
                cl.Id,
                cl.Name,
                cl.Description,
                cl.CreatedAt,
                cl.UpdatedAt,
                cl.DeletedAt

            }).ToList();

            return Ok(Contactslocations);
        }


    }
}