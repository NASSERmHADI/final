using final.Models;
using Microsoft.AspNetCore.Mvc;

namespace final.Controllers
{
    public class PedometerController : Controller
    {
        private StepsContext _context;
        public PedometerController (StepsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Steps()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StepsToCalories(Step TotalCaloriesBurned)
        {
            TotalCaloriesBurned.StepDate = DateTime.Now;

            _context.Steps.Add(TotalCaloriesBurned);
            _context.SaveChanges();

            return View(TotalCaloriesBurned);
        }
    }
}
