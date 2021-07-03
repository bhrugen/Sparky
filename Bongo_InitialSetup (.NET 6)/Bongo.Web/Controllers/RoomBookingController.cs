using Bongo.Core.Services.IServices;
using Bongo.Models.Model;
using Bongo.Models.Model.VM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bongo.Web.Controllers
{
    public class RoomBookingController : Controller
    {
        private IStudyRoomBookingService _studyRoomBookingService;

        public RoomBookingController(IStudyRoomBookingService studyRoomBookingService)
        {
            _studyRoomBookingService = studyRoomBookingService;
        }
        public IActionResult Index()
        {
            return View(_studyRoomBookingService.GetAllBooking());

        }
        public IActionResult Book()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Book(StudyRoomBooking studyRoomBooking)
        {
            IActionResult actionResult = View("Book");
            if (ModelState.IsValid)
            {
                var result = _studyRoomBookingService.BookStudyRoom(studyRoomBooking);
                if (result.Code == StudyRoomBookingCode.Success)
                {
                    actionResult = RedirectToAction("BookingConfirmation", result);
                }
                else if (result.Code == StudyRoomBookingCode.NoRoomAvailable)
                {
                    ViewData["Error"] = "No Study Room available for selected date";
                }
            }

            return actionResult;
        }
        public IActionResult BookingConfirmation(StudyRoomBookingResult studyRoomBooking)
        {
            return View(studyRoomBooking);
        }
    }
}
