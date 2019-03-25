using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using loginetTest.Entities;
using loginetTest.Interfaces;

namespace loginetTest.Context
{
    public class AlbumRepository : IRepository<Album>, IDisposable
    {
        private static DbSet<Album> Items = null;

        static AlbumRepository()
        {
            Items = ApiDbContext.Instance.Albums;
        }



        public IEnumerable<Album> GetList()
        {
            return Items;
        }

        public Album GetItem(int id)
        {
            return Items.FirstOrDefault(x => x.Id == id);
        }

        public List<Album> GetItemByUserId(int id)
        {
            return Items.Where(p=>p.UserId == id).ToList();

        }

        public void Create(Album item)
        {
            Items.Add(item);
            Save();
        }

        public void Update(Album item)
        {
            var firstOrDefault = Items.FirstOrDefault(x => x.Id == item.Id);
            if (firstOrDefault != null)
            {
                Items.Attach(firstOrDefault);
                Save();
            }
        }

        public void Delete(int id)
        {
            var firstOrDefault = Items.FirstOrDefault(x => x.Id == id);
            if (firstOrDefault != null)
            {
                Items.Remove(firstOrDefault);
                Save();
            }
        }

        public void Save()
        {
            ApiDbContext.Instance.SaveChanges();
        }

        public void Dispose()
        {

        }
    }
}