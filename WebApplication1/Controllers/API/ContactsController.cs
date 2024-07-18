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
    public class ContactsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpPost]
        [Route("api/PostContacts")]
        public IHttpActionResult PostContacts(ContactRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newContact = new SustainabilityContacts
            {
                Id = request.Contact.Id,
                Name = request.Contact.Name,
                Date = request.Contact.Date,
                Comment = request.Contact.Comment,
                CreatedAt = request.Contact.CreatedAt,
                UpdatedAt = request.Contact.UpdatedAt,
                DeletedAt = request.Contact.DeletedAt,
                Latitude = request.Contact.Latitude,
                Longitude = request.Contact.Longitude,
                LocationId = request.Contact.LocationId,
                TypeId = request.Contact.TypeId,
                UserId = request.Contact.UserId
            };

            db.SustainabilityContacts.Add(newContact);

            db.SaveChanges();

            var newContactsFarm = new SustainabilityContactFarm
            {
                ContactId = request.Contact.Id,
                FarmId = Guid.Parse(request.FarmId)
            };

            db.SustainabilityContactFarm.Add(newContactsFarm);

            if (request.TopicIds != null && request.TopicIds.Count > 0)
            {
                foreach (var topicId in request.TopicIds)
                {
                    var newContactTopic = new SustainabilityContactTopic
                    {
                        ContactId = request.Contact.Id,
                        TopicId = topicId
                    };
                    db.SustainabilityContactTopic.Add(newContactTopic);
                }
            }

            db.SaveChanges();

            return Ok(newContact);
        }
    }
}
