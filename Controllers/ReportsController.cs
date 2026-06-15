using Microsoft.AspNetCore.Mvc;

namespace gpos.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult DailySalesReport() => View();
        public IActionResult FuelSalesReport() => View();
        public IActionResult ProductSalesReport() => View();
        public IActionResult CashierSalesReport() => View();
        public IActionResult PaymentMethodReport() => View();
        public IActionResult DiscountReport() => View();
        public IActionResult PointsReport() => View();
        public IActionResult WarehouseStockReport() => View();
        public IActionResult DisplayStockReport() => View();
        public IActionResult StockTransferReport() => View();
        public IActionResult StockAdjustmentReport() => View();
        public IActionResult BeginningEndingInventoryReport() => View();
    }
}
