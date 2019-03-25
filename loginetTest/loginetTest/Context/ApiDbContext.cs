using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using loginetTest.Entities;

namespace loginetTest.Context
{
    public class ApiDbContext : DbContext
    {
        private static ApiDbContext _context = null;

        static ApiDbContext()
        {
            _context = new ApiDbContext();
        }
        private ApiDbContext() :base ("DefaultConnection") { }

        public static ApiDbContext Instance => _context;

        public DbSet<User> Users { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Album>().HasRequired<User>(p => p.CurrentUser).WithMany(p => p.Albums)
                .HasForeignKey(p => p.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}