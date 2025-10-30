using Microsoft.AspNetCore.Mvc;

namespace MVCApplication.Controllers
{
    public class helloworld : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
