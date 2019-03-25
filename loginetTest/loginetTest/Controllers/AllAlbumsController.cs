using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using loginetTest.Context;
using loginetTest.Entities;
using Newtonsoft.Json;

namespace loginetTest.Controllers
{
    public class AllAlbumsController : ApiController
    {
        // GET: api/AllAlbums
        public IEnumerable<Album> Get()
        {
            return new AlbumRepository().GetList();
        }

        // GET: api/AllAlbums/5

        public IEnumerable<Album> Get(int id)
        {
            return new AlbumRepository().GetItemByUserId(id);
        }

        // POST: api/AllAlbums
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AllAlbums/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AllAlbums/5
        public void Delete(int id)
        {
        }
    }
}
