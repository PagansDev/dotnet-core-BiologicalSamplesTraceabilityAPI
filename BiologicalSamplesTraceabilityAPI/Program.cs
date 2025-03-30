using BiologicalSamplesTraceabilityAPI.Data;
using BiologicalSamplesTraceabilityAPI.Models;
using BiologicalSamplesTraceabilityAPI.Services.RouteGroup;
using BiologicalSamplesTraceabilityAPI.Services.Routes;
using BiologicalSamplesTraceabilityAPI.Services.RouteType;
using BiologicalSamplesTraceabilityAPI.Services.SampleBatch;
using BiologicalSamplesTraceabilityAPI.Services.SampleType;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRouteType, RouteTypeService>();
builder.Services.AddScoped<IRoute, RouteService>();
builder.Services.AddScoped<ISampleType, SampleTypeService>();
builder.Services.AddScoped<ISampleBatch, SampleBatchService>();
builder.Services.AddScoped<IRouteGroup, RouteGroupService>();



builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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
