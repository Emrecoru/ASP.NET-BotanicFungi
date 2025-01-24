using Cantek.ArgeProjectNTier.Dtos.Interfaces;
using Cantek.ArgeProjectNTier.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantek.ArgeProjectNTier.Dtos
{
    public class RoomListDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string RoomType { get; set; }

        public string RoomImgPath { get; set; }

        public int RoomStatusId { get; set; }
        public RoomStatus RoomStatus { get; set; }
    }
}
