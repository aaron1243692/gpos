using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace gpos.Filters
{
    public class BlockSalesmanSessionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var employeeRole = context.HttpContext.Session.GetString("EmployeeRole");

            if (string.Equals(employeeRole, "salesman", StringComparison.OrdinalIgnoreCase))
            {
                context.Result = new RedirectToActionResult("POS", "Salesman", null);
                return;
            }

            base.OnActionExecuting(context);
        }
    }
}
