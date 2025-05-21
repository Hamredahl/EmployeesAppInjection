using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeesApp.Web.LogFilter
{
    public class LogFilterAttribute(ILogger<LogFilterAttribute> logger): ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            logger.LogInformation("Yeet");
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            logger.LogInformation("Yaat");
        }
    }
}
