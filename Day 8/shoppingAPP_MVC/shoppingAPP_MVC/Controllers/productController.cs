using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Core.Infrastructure;
using shoppingAPP_MVC.Models;

namespace shoppingAPP_MVC.Controllers
{
    public class productController : Controller
    {
      public IActionResult DisplayProducts()
        {
            productsDetails pObj = new productsDetails();
            return View(pObj.GetAllProducts());
        }
    }
}
