using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ValuesApi.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("ping")]
        public IHttpActionResult Ping()
        {
            return this.Ok("Pong!!!!!!");
        }
    }
}
