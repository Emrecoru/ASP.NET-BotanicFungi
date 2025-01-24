using Cantek.ArgeProjectNTier.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.DataAccess.Configurations
{
    public class ParameterConfiguration : IEntityTypeConfiguration<Parameter>
    {
        public void Configure(EntityTypeBuilder<Parameter> builder)
        {
            builder.Property(x => x.Type).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Value).HasColumnType("decimal(7,4)").HasPrecision(7,4).IsRequired();
        }
    }
}
