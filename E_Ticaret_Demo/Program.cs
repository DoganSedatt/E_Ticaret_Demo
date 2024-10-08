using Businnes;
using DataAccess;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<E_Ticaret_Context>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ETicaretDb")));
builder.Services.AddControllers();

builder.Services.GetDataAccessServices();//DataAccess katman�n� servislere ekledik=>IOC
builder.Services.GetBusinnesResolves();
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
