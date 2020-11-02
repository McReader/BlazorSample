using Microsoft.AspNetCore.Mvc;

namespace BlazorSample.Server.Controllers
{
    public class TodosController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}