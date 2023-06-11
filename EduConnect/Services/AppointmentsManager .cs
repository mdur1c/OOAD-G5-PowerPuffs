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
    public class AppointmentsManager : IAppointmentsManager
    {
        private readonly ApplicationDbContext _db;
        private readonly IHttpContextAccessor _contextAccessor;
        public string GetUserId()
        {
            return _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
        public AppointmentsManager(ApplicationDbContext db, IHttpContextAccessor contextAccessor)
        {
            _db = db;
            _contextAccessor = contextAccessor;
        }
        public async Task<IEnumerable<Appointment>> GetAppointmentsByCurrentPerformer()
        {
            var appointments = await _db.Appointments.Where(a => a.TutorUsername == GetUserId()).ToListAsync();
            return appointments;
        }
    }

}
