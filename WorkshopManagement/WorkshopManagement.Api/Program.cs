using Microsoft.EntityFrameworkCore;
using WorkshopManagement.Core.Interfaces;
using WorkshopManagement.Infrastructure.Data;
using WorkshopManagement.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Adding abstraction, when the program have a IAccidentRepository, use the AccidentRepository
builder.Services.AddTransient<IAccidentRepository, AccidentRepository>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IApplicationBuilder, ApplicationBuilder>();

builder.Services.AddDbContext<WorkshopManagementDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("WorkshopManagementDBConnectionString")));

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
