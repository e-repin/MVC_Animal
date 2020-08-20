using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnimalHomes.Controllers.api
{
    public class HomesController : ApiController
    {
        // GET: api/Homes
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Homes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Homes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Homes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Homes/5
        public void Delete(int id)
        {
        }
    }
}
