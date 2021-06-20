using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class ApointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}