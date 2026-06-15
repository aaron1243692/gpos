using Microsoft.AspNetCore.Mvc;

namespace gpos.Controllers
{
    public class SetupController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult Users() => View();
        public IActionResult Customers() => View();
        public IActionResult Categories() => View();
        public IActionResult Products() => View();
        public IActionResult FuelTypes() => View();
        public IActionResult Pumps() => View();
        public IActionResult Suppliers() => View();
        public IActionResult Discounts() => View();
        public IActionResult Settings() => View();
    }
}
