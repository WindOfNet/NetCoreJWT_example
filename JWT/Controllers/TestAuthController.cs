using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestAuthController : ControllerBase
    {
        // GET api/TestAuth
        [HttpGet]
        [Authorize]
        public ActionResult<string> Get()
        {
            return $"hi {User.Identity.Name}";
        }
    }
}
