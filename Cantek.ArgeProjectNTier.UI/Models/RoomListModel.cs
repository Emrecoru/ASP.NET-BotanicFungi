using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cantek.ArgeProjectNTier.UI.Models
{
    public class RoomCreateModel
    {
        public string Title { get; set; }

        public string RoomType { get; set; }

        public string RoomImgPath { get; set; }

        public int RoomStatusId { get; set; }

        public SelectList RoomStatuses { get; set; }
    }
}
