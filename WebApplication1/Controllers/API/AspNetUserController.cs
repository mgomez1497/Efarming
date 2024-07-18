using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication1.Controllers.API
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AspNetUserController : ApiController
    {
        private UserManager<IdentityUser> userManager;

        public AspNetUserController()
        {
            userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>());
        }

        

        [HttpPost]
        [Route("api/auth/entrar")]
        public IHttpActionResult Login2(string username, string password)
        {
            var user = userManager.Find(username, password);
            if (user != null)
            {
                return Ok(user.Id);
            }
            else
            {
                return BadRequest("Nombre de usuario o contraseña incorrectos.");
            }
        }
    }
}
