using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Entities
{
    public class Parameter : BaseEntity
    {
        public string Type { get; set; }
        public decimal Value { get; set; }

        public List<RoomParameter> RoomParameters { get; set; }
    }
}
