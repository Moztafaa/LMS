using Entities.IRepository;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    public class CourseController : Controller
    {
        private readonly IunitOfWork _unitOfWork;

        public CourseController(IunitOfWork unitofwork)
        {
            _unitOfWork = unitofwork;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _unitOfWork.Courserepo.GetAllAsync(null, "Instructor");

            return View("Course", result as List<Course>);
        }

        public async Task<IActionResult> ShowCourse(int id)
        {
            var crs = await _unitOfWork.Courserepo.GetFirstOrDefaultAsync(x => x.Id == id, "Instructor");
            return View("CourseDetails", crs);
        }
    }
}