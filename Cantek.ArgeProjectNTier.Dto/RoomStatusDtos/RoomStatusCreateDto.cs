using Cantek.ArgeProjectNTier.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Dtos
{
    public class RoomStatusCreateDto : IDto
    {
        public string Definition { get; set; }
        public double SquareMeters { get; set; }

    }
}
