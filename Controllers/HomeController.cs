using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult testt()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitContact(ContactModel model)
        {
            // You now have Name, Email, and Message available as model properties
            // Example: string userName = model.Name;

            // Do something with the data (e.g., save to DB or display)
            return View("Thankyou", model); // or redirect
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
