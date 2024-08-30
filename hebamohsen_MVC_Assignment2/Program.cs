namespace hebamohsen_MVC_Assignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseRouting();


            #region MyRegion
            //app.Use(async (context, next) =>
            //    {
            //        Endpoint endpoint = context.GetEndpoint();

            //        if (endpoint is null)
            //            await context.Response.WriteAsync("Your Requested Page Not Found");

            //        await next();

            //    });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You are at Home page");
            //    });
            //    endpoints.MapGet("/Products", async context =>
            //    {
            //        await context.Response.WriteAsync("You are at Products page");
            //    });
            //    endpoints.MapGet("/Products/{id:int?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["id"];

            //        if (idData is not null)
            //        {
            //            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //            await context.Response.WriteAsync($"You Request Products with Id =>{id}");
            //        }
            //        else
            //            await context.Response.WriteAsync("You are at Products page");


            //    });
            //    endpoints.MapGet("/Books/{id}/{auther:alpha:minlength(4):maxlength(6)}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //        string auther = context.Request.RouteValues["auther"].ToString();
            //        await context.Response.WriteAsync($"You Request Book with Id => {id} and Auther => {auther}");
            //    });
            //});

            //app.Run(async (HttpContext) =>
            //{
            //    await HttpContext.Response.WriteAsync("Your Requested Page Not Found");
            //});

            #endregion

            app.MapControllerRoute(
                name:"default",
                pattern: "/{Controller=Home}/ {Action=Index}",
                defaults: new{Controller="Home",Action="Index"}

                );

            app.Run();
        }
    }
}
