using Microsoft.AspNetCore.Mvc;

namespace stateAgent.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
