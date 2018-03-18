using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleAPI.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route("getValues")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [Route("getVal")]
        public string Get(int id)
        {
            return "value " + id.ToString();
        }

        // POST api/values
        [Route("postVal")]
        public HttpResponseMessage Post([FromBody]string value)
        {
            string val = value;
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.Created };
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
