using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.Controllers
{
    public class HomeController: Controller
    {
        [Route("index"), HttpGet]
        public async Task<ActionResult> Index()
        {
            return Json(new { values = 100 });
        }
    }
}
