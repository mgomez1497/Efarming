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
    public class ContactTopicController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ContactTopic
        [HttpPost]
        [Route("api/PostContactsTopics")]

        public IHttpActionResult PostContactsTopics(SustainabilityContactTopic contactTopic, string contactId, string topicId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newContact = new SustainabilityContactTopic
            {
                ContactId = Guid.Parse(contactId),
                TopicId = int.Parse(topicId)
            };

            db.SustainabilityContactTopic.Add(newContact);
            db.SaveChanges();

            return Ok(newContact);
        }

    }
}
