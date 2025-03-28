using FirstWebApp.Controller;
using FirstWebApp.Model.Repository;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//get the container
IServiceCollection container = builder.Services;

//registering services and providers
container.AddSingleton<ContactController>();
container.AddDbContext<EpsilonDbContext>(options => options.UseSqlServer(@"server=.\sqlexpress;database=epsilondb;user id=sa;password=sqlserver2024;TrustServerCertificate=true"), ServiceLifetime.Singleton);
//container.AddSingleton<ProductController>();

WebApplication app = builder.Build();

//app.Use(async (HttpContext context, RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("1st middleware..");
//    await next(context);
//});
//app.Use(async (HttpContext context, RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("2nd middlweare..");
//    await next(context);
//});

var contactController = app.Services.GetRequiredService<ContactController>();
//var productController = app.Services.GetRequiredService<ProductController>();

app.MapGet("/contacts", contactController.GetContacts);
app.MapGet("/contacts/{contactid}", contactController.GetContact);
app.MapPost("/contacts", () => contactController.AddContact);

//app.MapGet("/products", () => productController.GetProducts);

//app.MapControllers();

app.Run();


