using consumeAPI_HttpClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace consumeAPI_HttpClient.Controllers
{
    public class ExternalDataController : Controller
    {

        userPost postObj = new userPost();
        public IActionResult UserPost()
        {
            ViewBag.data = postObj.GetPostData();
            return View();
        }

        public IActionResult externaldata()
        {
            return View();
        }
    }
}
