using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTemplate.Models;

namespace WebApiTemplate.Controllers
{
    public class IntroductionController : ApiController
    {
        [Route("Hi")]
        public string Get([FromBody]Person person)
        {
            return string.Format("Hi, {0} {1}", person.Name, person.FamilyName);
        }

        [Route("hi")]
        public Person Get(/*[FromUri]*/string name, /*[FromUri]*/string familyName)
        {
            var person = new Person()
            {
                Name = name, 
                FamilyName = familyName
            };
            return person;
        }
    }
}
