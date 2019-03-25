using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using loginetTest.Entities;
using loginetTest.Interfaces;

namespace loginetTest.Context
{
    public class UserRepository : IRepository<User>, IDisposable
    {
        private static DbSet<User> Items;

        static UserRepository()
        {
            Items = ApiDbContext.Instance.Users;
        }


        public IEnumerable<User> GetList()
        {
            return Items;
        }

        public User GetItem(int id)
        {
            return Items.FirstOrDefault(p => p.Id == id);
        }

        public void Create(User item)
        {
            Items.Add(item);
            Save();
        }

        public void Update(User item)
        {
            var firstOrDefault = Items.FirstOrDefault(p => p.Id == item.Id);
            if (firstOrDefault != null)
            {
                Items.Attach(firstOrDefault);
                Save();
            }
        }

        public void Delete(int id)
        {
            var firstOrDefault = Items.FirstOrDefault(p => p.Id == id);
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