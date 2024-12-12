namespace App.Web.Services
{
    public static class RoutingExtension
    {
        public static IEndpointRouteBuilder AreaEndpointRouteBuilder(this IEndpointRouteBuilder builder)
        {
            builder.MapAreaControllerRoute(
                name: "AreaAdmin",
                areaName: "Admin",
                pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

            builder.MapAreaControllerRoute(
                name: "AreaVisitor",
                areaName: "Visitor",
                pattern: "Visitor/{controller=Home}/{action=Index}/{id?}");

            return builder;
        }
    }
}
