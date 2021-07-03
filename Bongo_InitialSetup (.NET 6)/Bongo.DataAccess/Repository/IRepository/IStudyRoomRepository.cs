using Bongo.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bongo.DataAccess.Repository.IRepository
{
    public interface IStudyRoomRepository
    {
        IEnumerable<StudyRoom> GetAll();
      

        

    }
}
