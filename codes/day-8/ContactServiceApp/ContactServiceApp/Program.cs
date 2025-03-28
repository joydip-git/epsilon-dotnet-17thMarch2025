using ContactServiceApp.DAL;
using ContactServiceApp.Models;
using ContactServiceApp.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var conStr = builder.Configuration.GetConnectionString("EpsilonConStr");
builder.Services.AddDbContext<EpsilonDbContext>(
    options => options.UseSqlServer(conStr));
builder.Services.AddScoped<IDaoContract<Contact, long>, ContactDao>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
