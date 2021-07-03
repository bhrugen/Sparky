using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bongo.Models.Model.VM
{
    public class StudyRoomBookingResult : StudyRoomBookingBase
    {
        public StudyRoomBookingCode Code { get; set; }
        public int BookingId { get; set; }
    }
}
