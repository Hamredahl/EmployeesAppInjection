using EmployeesApp.Web.LogFilter;
using EmployeesApp.Web.Services;

namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IEmployeeService, OtherEmployeeService>();
            builder.Services.AddScoped<LogFilterAttribute>();
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllers();

            app.Run();
        }
    }
}