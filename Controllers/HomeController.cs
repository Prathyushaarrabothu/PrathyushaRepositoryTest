using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IHomeservice homeservice;

        public HomeController(ILogger<HomeController> logger,IHomeservice _service)
        {
            _logger = logger;
            homeservice = _service;
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

            ResponseModel response =  homeservice.GetWelcomeMessages(model); 
          // Example usage of the service
            return View("Thankyou", response); // or redirect
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
