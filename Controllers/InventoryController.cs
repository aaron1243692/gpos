using Microsoft.AspNetCore.Mvc;

namespace gpos.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult WarehouseInventory() => View();
        public IActionResult DisplayInventory() => View();
        public IActionResult StockReceiving() => View();
        public IActionResult StockTransfer() => View();
        public IActionResult StockAdjustment() => View();
        public IActionResult LowStockItems() => View();
    }
}
