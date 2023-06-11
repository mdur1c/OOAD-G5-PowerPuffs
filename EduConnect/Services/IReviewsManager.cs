using EduConnect.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduConnect.Services
{
    public interface IReviewsManager
    {
        public Task<IEnumerable<Reviews>> GetReviewsByCurrentPerformer();
    }
}
