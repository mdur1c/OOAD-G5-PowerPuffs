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
    public class ReviewsManager : IReviewsManager
    {
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _contextAccessor;
        public string GetUserId()
        {
            return _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
        public ReviewsManager(ApplicationDbContext db, IHttpContextAccessor contextAccessor)
        {
            _db = db;
            _contextAccessor = contextAccessor;
        }
        public async Task<IEnumerable<Reviews>> GetReviewsByCurrentPerformer()
        {
            var reviews = await _db.Reviews.Where(r => r.TutorId == GetUserId()).ToListAsync();

            return reviews;
        }
    }
}
