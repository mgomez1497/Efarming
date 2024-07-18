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
    public class ContactsFarmsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ContactTopic
        [HttpPost]
        [Route("api/PostContactsFarms")]

        public IHttpActionResult PostContactsFarms(SustainabilityContactFarm contactFarms, string contactId, string farmId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newContact = new SustainabilityContactFarm
            {
                ContactId = Guid.Parse(contactId),
                FarmId = Guid.Parse(farmId)
            };
            db.SustainabilityContactFarm.Add(newContact);
            db.SaveChanges();

            return Ok(newContact);
        }
    }
}
