using Bongo.Core.Services.IServices;
using Bongo.Models.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bongo.Web.Controllers
{
    public class RoomsController : Controller
    {
        private readonly IStudyRoomService _studyRoomService;
        public RoomsController(IStudyRoomService studyRoomService)
        {
            _studyRoomService = studyRoomService;
        }
        public IActionResult Index()
        {
            return View(_studyRoomService.GetAll());
        }

       
    }
}
