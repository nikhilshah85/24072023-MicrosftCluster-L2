using consumeAPI_HttpClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace consumeAPI_HttpClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult DisplayComments()
        {
            CommentDetails commentObj = new CommentDetails(); //use DI please
            ViewBag.comments = commentObj.GetComments();
            return View();
        }

        public IActionResult Index()
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