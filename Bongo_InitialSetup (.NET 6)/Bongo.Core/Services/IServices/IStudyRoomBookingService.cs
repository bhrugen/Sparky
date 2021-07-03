using Bongo.Models.Model;
using Bongo.Models.Model.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bongo.Core.Services.IServices
{
    public interface IStudyRoomBookingService
    {
        StudyRoomBookingResult BookStudyRoom(StudyRoomBooking request);
        IEnumerable<StudyRoomBooking> GetAllBooking();
    }
}
