using Microsoft.AspNetCore.Mvc;

namespace consumeWebAPI.Controllers
{
    public class ExternalDataController : Controller
    {
        public IActionResult Postdata()
        {
            return View();
        }
    }
}
