using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using REALtor1._2.Data.Models;

namespace REALtor1._2.Data
{
    public class DbContent:IdentityDbContext<IdentityUser>
    {
        public DbContent(DbContextOptions<DbContent> options):base(options)
        {

        }
        public DbSet<House> House { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<IdentityUser> IdUser { get; set; }
    }
}
