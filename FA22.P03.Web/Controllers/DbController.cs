using Microsoft.AspNetCore.Mvc;

namespace FA22.P03.Web.Controllers
{

    public class MyController : Controller
    {
        private readonly ProductDb _context;

        public MyController(ProductDb context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
