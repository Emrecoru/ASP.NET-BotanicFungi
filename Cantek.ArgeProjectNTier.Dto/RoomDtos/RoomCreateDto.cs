using Cantek.ArgeProjectNTier.Dtos.Interfaces;
using Cantek.ArgeProjectNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Dtos
{
    public class RoomCreateDto : IDto
    {
        public string Title { get; set; }

        public string RoomType { get; set; }

        public string RoomImgPath { get; set; }

        public int RoomStatusID { get; set; }
    }
}
