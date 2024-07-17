using Microsoft.AspNetCore.Mvc;

namespace weather_prediction_app.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
