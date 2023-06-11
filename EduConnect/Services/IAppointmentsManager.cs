using EduConnect.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduConnect.Services
{
    public interface IAppointmentsManager
    {
        public Task<IEnumerable<Appointment>> GetAppointmentsByCurrentPerformer();
    }
}
