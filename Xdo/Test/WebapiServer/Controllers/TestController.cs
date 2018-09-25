using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebapiClient;

namespace WebapiServer.Controllers
{
    public class TestController : ApiController
    {
        // GET api/values
        public IEnumerable<User> Get()
        {
            return new User[] { new User()
            {
                name = "Cok",
                age = 33
            },new User()
            {
                name = "Jane",
                age = 35
            }
        };
        }

        
        // GET api/values/5
        public User Get(int id)
        {
            return new User()
            {
                name = "LiSA",
                age = 30 + id
            };
        }
        
        // POST api/values
        public void Post(dynamic u)
        {
            
        }

        // PUT api/values/5
        public void Put(int id, [System.Web.Http.FromBody]User u)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }


    }
}
