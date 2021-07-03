using Bongo.Models.Model.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bongo.Models.Model
{
    public class StudyRoomBooking : StudyRoomBookingBase
    {
        [Key]
        public int BookingId { get; set; }
        public int StudyRoomId { get; set; }
    }
}
