using Bongo.DataAccess.Repository.IRepository;
using Bongo.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bongo.DataAccess.Repository
{
    public class StudyRoomBookingRepository : IStudyRoomBookingRepository
    {
        private readonly ApplicationDbContext _context;

        public StudyRoomBookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

       
        public IEnumerable<StudyRoomBooking> GetAll(DateTime? date)
        {
            if (date != null)
            {
                return _context.StudyRoomBookings.Where(x => x.Date == date).OrderBy(x => x.BookingId).ToList();
            }
            return _context.StudyRoomBookings.OrderBy(x => x.BookingId).ToList();
        }

        public void Book(StudyRoomBooking booking)
        {
            _context.StudyRoomBookings.Add(booking);
            _context.SaveChanges();
        }
    }
}
