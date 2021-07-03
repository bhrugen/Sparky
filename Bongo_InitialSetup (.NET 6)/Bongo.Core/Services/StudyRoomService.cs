using Bongo.Core.Services.IServices;
using Bongo.DataAccess.Repository.IRepository;
using Bongo.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bongo.Core.Services
{
    public class StudyRoomService : IStudyRoomService
    {
        private readonly IStudyRoomRepository _studyRoomRepository;
        public StudyRoomService(IStudyRoomRepository studyRoomRepository)
        {
            _studyRoomRepository = studyRoomRepository;
        }


        public IEnumerable<StudyRoom> GetAll()
        {
            return _studyRoomRepository.GetAll();
        }

      
    }
}
