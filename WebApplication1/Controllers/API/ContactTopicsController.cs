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
    public class ContactTopicsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        [Route("api/GetContactsTopics")]
        public IHttpActionResult getContactsTopics()
        {
            var Contacts = db.SustainabilityContactTopics.Select(c => new
            {
                c.Id,
                c.Name,
                c.Description,
                c.CreatedAt,
                c.UpdatedAt,
                c.DeletedAt

            }).ToList();

            return Ok(Contacts);
        }


    }
}
