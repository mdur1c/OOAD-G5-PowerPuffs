using EduConnect.Data;
using EduConnect.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EduConnect.Services
{
    public class CourseManager : ICourseManager
    {
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _contextAccessor;
        public string GetUserId()
        {
            return _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
        public CourseManager(ApplicationDbContext db, IHttpContextAccessor contextAccessor)
        {
            _db = db;
            _contextAccessor = contextAccessor;
        }
        public async Task<IEnumerable<Course>> GetCoursesByCurrentPerformer()
        {
            var courses = await _db.Courses.Where(c => c.TutorUsername == GetUserId()).ToListAsync();
            return courses;
        }


    }
}


