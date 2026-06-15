using Microsoft.AspNetCore.Mvc;

namespace gpos.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult DailyBeginningBalance() => View();
        public IActionResult PumpTransaction() => View();
        public IActionResult PosProductSales() => View();
        public IActionResult PointsRedemption() => View();
        public IActionResult DailyClosingBalance() => View();
        public IActionResult ReceiptPreview() => View();
    }
}
