using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebApiTemplate.Controllers
{
    public class PingController : ApiController
    {
        [Route("api/ping")]
        public string Get()
        {
            return "Ping Succesfull!";
        }
    }
}