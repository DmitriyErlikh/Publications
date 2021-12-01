using Microsoft.EntityFrameworkCore;
using Publications.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publications.DAL.Context
{
    public class PublicationsDB : DbContext
    {
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Person> Persons { get; set; }
        public PublicationsDB(DbContextOptions<PublicationsDB> Options) : base(Options)
        {

        }
    }
}
