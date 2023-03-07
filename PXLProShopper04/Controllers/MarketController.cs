using Microsoft.AspNetCore.Mvc;

namespace PXLProShopper04.Controllers
{
    public class MarketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
