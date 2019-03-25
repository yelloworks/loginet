using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using loginetTest.Entities;

namespace loginetTest.Context
{
    public class DbInitialiizer: DropCreateDatabaseAlways<ApiDbContext>
    {
        protected override void Seed(ApiDbContext context)
        {
            var users = new List<User>
            {
                new User {Name = "User1"},
                new User {Name = "User2"}
            };

            context.Users.AddRange(users);
            context.SaveChanges();

            var albums = new List<Album>
            {
                new Album {Name = "U1Album1", UserId = 1},
                new Album {Name = "U1Album2", UserId = 1},
                new Album {Name = "U1Album3", UserId = 1},
                new Album {Name = "U2Album1", UserId = 2},
                new Album {Name = "U2Album2", UserId = 2},
            };

            context.Albums.AddRange(albums);
            context.SaveChanges();


            base.Seed(context);
        }
    }
}