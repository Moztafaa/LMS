using Entities.IRepository;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IunitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IunitOfWork unitofwork)
        {
            _logger = logger;
            _unitOfWork = unitofwork;
        }

        public async Task<IActionResult> Index()
        {
            var courses = await _unitOfWork.Courserepo.GetAllAsync(null, "Track,Instructor");
            var Allinstructors = await _unitOfWork.instructorrepo.GetAllAsync(null, "Track");


            ViewBag.instructors = Allinstructors;

            return View((List<Course>)courses);
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