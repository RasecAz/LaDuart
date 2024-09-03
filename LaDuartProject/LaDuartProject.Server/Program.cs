using LaDuartProject.Infraestructure.Data;
using LaDuartProjet.Core.Interfaces.IServices;
using LaDuartProjet.Core.Interfaces.Repositories;
using LaDuartProjet.Core.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer("DbConnection"));

builder.Services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
builder.Services.AddScoped<IProductoService, ProductoService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyCors", app =>
    {
        app
    .SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
    .AllowAnyHeader()
    .AllowAnyOrigin()
    .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
