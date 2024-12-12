namespace App.Web.Services
{
    public static class RoutingExtension
    {
        public static IEndpointRouteBuilder AreaEndpointRouteBuilder(this IEndpointRouteBuilder endpointRoutebuilder)
        {
            endpointRoutebuilder.MapAreaControllerRoute(
                name: "AreaCRM",
                areaName: "CRM",
                pattern: "CRM/{controller=Home}/{action=Index}/{id?}");

            endpointRoutebuilder.MapAreaControllerRoute(
                name: "AreaPurchase",
                areaName: "Purchase",
                pattern: "Purchase/{controller=Home}/{action=Index}/{id?}");

            endpointRoutebuilder.MapAreaControllerRoute(
                name: "AreaSales",
                areaName: "Sales",
                pattern: "Sales/{controller=Home}/{action=Index}/{id?}");

            endpointRoutebuilder.MapAreaControllerRoute(
                name: "AreaSetup",
                areaName: "Setup",
                pattern: "Setup/{controller=Home}/{action=Index}/{id?}");

            return endpointRoutebuilder;
        }
    }
}
