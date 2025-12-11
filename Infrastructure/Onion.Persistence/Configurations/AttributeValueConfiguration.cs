using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Domain.Models;

namespace Onion.Persistence.Configurations
{
    public class AttributeValueConfiguration : IEntityTypeConfiguration<AttributeValue>
    {
        public void Configure(EntityTypeBuilder<AttributeValue> builder)
        {
            builder
                .HasKey(av => new { av.EntityId, av.AttributeId });

            builder
                .HasOne(av => av.Entity)
                .WithMany(e => e.AttributeValues)
                .HasForeignKey(av => av.EntityId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(av => av.EntityAttribute)
                .WithMany(ea => ea.AttributeValues)
                .HasForeignKey(av => av.AttributeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
