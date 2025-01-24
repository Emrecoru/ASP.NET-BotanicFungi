using Cantek.ArgeProjectNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Dtos
{
    public class RoomStatusListDto : IDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public decimal SquareMeters { get; set; }
    }
}
