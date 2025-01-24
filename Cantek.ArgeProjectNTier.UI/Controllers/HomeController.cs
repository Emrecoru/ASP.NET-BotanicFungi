using Cantek.ArgeProjectNTier.Business.Interfaces;
using Cantek.ArgeProjectNTier.UI.Extensions;
using Cantek.ArgeProjectNTier.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Azure.Core.HttpHeader;

namespace Cantek.ArgeProjectNTier.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRoomService _roomService;
        private readonly IParameterService _parameterService;
        private readonly IRoomStatusService _roomStatusService;

        public HomeController(IRoomService roomService, IParameterService parameterService, IRoomStatusService roomStatusService)
        {
            _roomService = roomService;
            _parameterService = parameterService;
            _roomStatusService = roomStatusService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _roomService.GetAllAsync();
            return this.ResponseView(response);
        }

        public async Task<IActionResult> ActiveRooms()
        {
            var response = await _roomService.GetActivesAsync();
            return this.ResponseView(response);
        }
    }
}
