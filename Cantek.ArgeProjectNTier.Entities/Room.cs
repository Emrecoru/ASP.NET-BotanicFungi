using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Entities
{
    public class Room : BaseEntity
    {
        public string Title { get; set; }

        public int RoomStatusId { get; set; }

        public RoomStatus RoomStatus { get; set; }

        public string RoomType { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<RoomParameter> RoomParameters { get; set; }

        public string RoomImgPath { get; set; }
    }
}
