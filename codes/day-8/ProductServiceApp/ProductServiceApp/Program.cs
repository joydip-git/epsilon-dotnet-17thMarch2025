using Microsoft.EntityFrameworkCore;
using ProductServiceApp.Models;
using ProductServiceApp.Models.DAL;
using ProductServiceApp.Models.Repository;

var builder = WebApplication.CreateBuilder(args);

//before build
//registering services for required infrastructure
IServiceCollection container = builder.Services;
container.AddControllers();
container.AddDbContext<EpsilonDbContext>(
    options => options.UseSqlServer(@"server=.\sqlexpress;database=epsilondb;user id=sa;password=sqlserver2024;TrustServerCertificate=true"),
    ServiceLifetime.Singleton
    );
container.AddSingleton<IDaoContract<Product>, ProductDao>();

var app = builder.Build();

//after build
//use the middlewares
app.UseRouting();
app.MapControllers();

app.Run();
