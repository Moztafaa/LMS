using System.Security.Claims;
using Entities.IRepository;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMS.Controllers
{
    public class CourseController : Controller
    {
        private readonly IunitOfWork _unitOfWork;
        private readonly DB _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public CourseController(IunitOfWork unitofwork , DB db,UserManager<ApplicationUser> userManager )
        {
            _unitOfWork = unitofwork;
            _db = db;
            _userManager = userManager;
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

        [HttpPost]
        public async Task<IActionResult> Enroll(int courseId)
        {
            // var username = User.FindFirstValue(ClaimTypes.Name);

            // get the name of the logged in user <ApplicationUser>
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            var username = user.Name;
            var trainee = await _db.Trainees.FirstOrDefaultAsync( x => x.Name == username);
            if (trainee == null)
            {
                return NotFound("Trainee not found");
                
            }
            var traineeCourse = new TraineeCourse
            {
                CourseId = courseId,
                TraineeId = trainee.Id
            };
            _db.TraineeCourses.Add(traineeCourse);
            await _db.SaveChangesAsync();
            return RedirectToAction("ShowCourse", new { id = courseId });
            

        }
        
    }
}