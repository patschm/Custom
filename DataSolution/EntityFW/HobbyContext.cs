using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFW.Entities;

namespace EntityFW
{
    public class HobbyContext : DbContext
    {
        public HobbyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonHobby>().HasKey(ph=>new { ph.PersonID, ph.HobbyID });
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Hobby> Hobby { get; set; }
    }
}
