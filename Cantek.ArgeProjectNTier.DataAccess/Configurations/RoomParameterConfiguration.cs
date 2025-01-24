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
    public class RoomParameterConfiguration : IEntityTypeConfiguration<RoomParameter>
    {
        public void Configure(EntityTypeBuilder<RoomParameter> builder)
        {
            builder.HasIndex(x => new
            {
                x.ParameterId,
                x.RoomId
            }).IsUnique();

            builder.HasOne(x => x.Room).WithMany(x => x.RoomParameters).HasForeignKey(x => x.RoomId);
            builder.HasOne(x => x.Parameter).WithMany(x => x.RoomParameters).HasForeignKey(x => x.ParameterId);
        }
    }
}
