using GroceryBackend;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<GroceryContext>(x => {
    x.UseSqlServer(builder.Configuration.GetConnectionString("GroceryContext"));
});
var app = builder.Build();

app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
