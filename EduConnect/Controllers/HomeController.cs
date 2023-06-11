using EduConnect.Data;
using EduConnect.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EduConnect.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext applicationDbContext, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = applicationDbContext;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return View() as IActionResult;
            var roles = await _userManager.GetRolesAsync(user);
            var role = roles[0];
            if (role == "Student")
            {
                return RedirectToAction(nameof(StudentHome));
            }
            else if (role == "Tutor")
            {
                return RedirectToAction(nameof(TutorHome));
            }
            else return View() as IActionResult;
            return View();
        }

        public async Task<IActionResult> StudentHome()
        {
            return View();
        }

        public async Task<IActionResult> TutorHome()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
