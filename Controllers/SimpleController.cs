using APICore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICore.Controllers
{
    public class SimpleController : ApiController
    {
        [HttpGet]
        [Route("api/v1/GetSimpleUser/[name]")]
        public IHttpActionResult GetUserByName(string name)
        {
            return Ok(new Simple
            {
                Name = name,
                Email = name + "@gmail.com"
            });
        }

        [HttpPost]
        [Route("api/v1/AddSimpleuser/")]
        public IHttpActionResult AddUser(string name)
        {
            Simple simple = new Simple();
            return Ok(name);
        }
    }
}
