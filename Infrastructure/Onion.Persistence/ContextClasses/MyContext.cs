using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Onion.Domain.Models;

namespace Onion.Persistence.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Entity> Entities { get; set; }
        public DbSet<EntityAttribute> EntityAttributes { get; set; }
        public DbSet<AttributeValue> AttributeValues { get; set; }
    }
}
