using Microsoft.AspNetCore.Mvc;

namespace gpos.Controllers
{
    public class LogsController : Controller
    {
        public IActionResult ActivityLogs() => View();
    }
}
