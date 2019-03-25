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
    public class AlbumController : ApiController
    {
        // GET: api/Album
        public IEnumerable<Album> Get()
        {
            return new AlbumRepository().GetList();
        }

        // GET: api/Album/5
        public Album Get(int id)
        {
            return new AlbumRepository().GetItem(id);
        }


        // POST: api/Album
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Album/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Album/5
        public void Delete(int id)
        {
        }
    }
}
