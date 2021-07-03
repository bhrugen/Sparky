using Bongo.Models.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bongo.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<StudyRoom> StudyRooms { get; set; }
        public DbSet<StudyRoomBooking> StudyRoomBookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudyRoom>().HasData(
                new StudyRoom
                {
                    Id=1,
                    RoomName="Everest",
                    RoomNumber="A101"
                }
            );
            modelBuilder.Entity<StudyRoom>().HasData(
                new StudyRoom
                {
                    Id = 2,
                    RoomName = "Superior",
                    RoomNumber = "A201"
                }
            );
            modelBuilder.Entity<StudyRoom>().HasData(
                new StudyRoom
                {
                    Id = 3,
                    RoomName = "Victoria",
                    RoomNumber = "A301"
                }
            );
        }
    }
}
