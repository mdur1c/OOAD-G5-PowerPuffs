using EduConnect.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduConnect.Services
{
    public interface ICourseManager
    {
        public Task<IEnumerable<Course>> GetCoursesByCurrentPerformer();
    }
}
