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
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(7).IsRequired();
            builder.Property(x => x.RoomType).HasMaxLength(7).IsRequired();
            builder.Property(x => x.CreatedDate).HasDefaultValueSql("getdate()");
            builder.Property(x => x.RoomImgPath).HasMaxLength(500).IsRequired();

            builder.HasOne(x => x.RoomStatus).WithMany(x => x.Rooms).HasForeignKey(x => x.RoomStatusId);

        }
    }
}
