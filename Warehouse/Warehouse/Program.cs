using Microsoft.EntityFrameworkCore;
using Warehouse.Data_Access;
using Warehouse.Factories;
using Warehouse.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register DbContext
//builder.Services.AddDbContext<WarehouseContext>(options=>options.UseMySql())

// Register Repository and service

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

// Register Factories
builder.Services.AddScoped<IProductFactory, ProductFactory>();
builder.Services.AddScoped<IProductFactory, FoodProductFactory>();



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
