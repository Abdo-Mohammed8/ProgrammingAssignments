namespace MVC01_DEMO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Register Services in DI Container
            builder.Services.AddControllersWithViews();


            #endregion


            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            //app.MapGet("/abdo", () => "Hello World!"); // static segment
            //app.MapGet("/{name}", async (context) =>
            //{
            //    var name = context.GetRouteValue("name");
            //    await context.Response.WriteAsJsonAsync($"Hello {name}");


            //}); // dynamic segment

            app.MapControllerRoute(
                name: "Default",
                pattern : "{Controller=Home}/{Action=Index}/{id?}",
                defaults : new {Controoler = "Home" , Action = "Index"}                );

            app.Run();
        }
    }
}
