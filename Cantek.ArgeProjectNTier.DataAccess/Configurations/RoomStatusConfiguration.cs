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
    public class RoomStatusConfiguration : IEntityTypeConfiguration<RoomStatus>
    {
        public void Configure(EntityTypeBuilder<RoomStatus> builder)
        {
            builder.Property(x => x.Definition).HasMaxLength(10);
            builder.Property(x => x.SquareMeters).HasColumnType("decimal(5, 2)").HasPrecision(5, 2);
        }
    }
}
