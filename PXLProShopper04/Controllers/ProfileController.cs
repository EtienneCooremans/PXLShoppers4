using Microsoft.AspNetCore.Mvc;

namespace PXLProShopper04.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
