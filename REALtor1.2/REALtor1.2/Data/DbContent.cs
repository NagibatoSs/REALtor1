using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using REALtor1._2.Data.Models;

namespace REALtor1._2.Data
{
    public class DbContent:DbContext
    {
        public DbContent(DbContextOptions<DbContent> options):base(options)
        {

        }
        public DbSet<House> House { get; set; }
        public DbSet<Person> Person { get; set; }
    }
}
