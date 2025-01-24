using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Entities
{
    public class RoomParameter : BaseEntity
    {
        public int RoomId { get; set; }

        public Room Room { get; set; }

        public int ParameterId { get; set; }

        public Parameter Parameter { get; set; }
    }
}
