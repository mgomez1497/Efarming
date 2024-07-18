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
    public class SupplyChainController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: SupplyChain

        [HttpGet]
        [Route("api/SupplyChain")]
        public IHttpActionResult GetSupplyChain()
        {
            var Supply = db.SupplyChains.Select(S => new
            {
                S.Id,
                S.Name, 
                S.CreatedAt,
                S.UpdatedAt,
                S.DeletedAt
            }).ToList();
            return Ok(Supply);
        }
    }
}
