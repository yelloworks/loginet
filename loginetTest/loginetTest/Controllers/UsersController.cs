using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using loginetTest.Context;
using loginetTest.Entities;

namespace loginetTest.Controllers
{
    public class UsersController : ApiController
    {
        // GET: api/Users
        public IEnumerable<User> Get()
        {
            return new UserRepository().GetList();
        }

        // GET: api/Users/5
        public User Get(int id)
        {
            return new UserRepository().GetItem(id);
        }

        // POST: api/Users
        public void Post([FromBody]User value)
        {
            new UserRepository().Update(value);
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
            new UserRepository().Delete(id);
        }
    }
}
