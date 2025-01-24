using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Entities
{
    public class RoomStatus : BaseEntity
    {
        public string Definition { get; set; }
        public double SquareMeters { get; set; }

        public List<Room> Rooms { get; set; }
    }

}
