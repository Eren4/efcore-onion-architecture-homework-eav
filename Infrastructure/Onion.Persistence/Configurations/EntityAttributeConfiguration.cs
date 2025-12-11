using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Domain.Models;

namespace Onion.Persistence.Configurations
{
    public class EntityAttributeConfiguration : IEntityTypeConfiguration<EntityAttribute>
    {
        public void Configure(EntityTypeBuilder<EntityAttribute> builder)
        {
            builder
                .HasOne(ea => ea.Entity)
                .WithMany(e => e.EntityAttributes)
                .HasForeignKey(ea => ea.EntityId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(ea => ea.AttributeValues)
                .WithOne(av => av.EntityAttribute);
        }
    }
}
