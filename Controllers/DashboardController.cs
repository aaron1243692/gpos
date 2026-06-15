using Microsoft.AspNetCore.Mvc;

namespace gpos.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Admin() => View();
        public IActionResult Manager() => View();
        public IActionResult Cashier() => View();
        public IActionResult Inventory() => View();
    }
}
