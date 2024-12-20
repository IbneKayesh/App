using App.DBC;
using App.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<AppDbContext>(options =>
{
    //options.UseSqlServer(connectionString: builder.Configuration.GetConnectionString("appDbConnection"));
    //options.UseInMemoryDatabase("ApDBMemory");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();

    app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


/**********************************************/
//Areas Endpoint should be before Controller route
app.AreaEndpointRouteBuilder();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
