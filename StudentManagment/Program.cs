using StudentManagment.Infrastructure;
using StudentManagment.Application;
using StudentManagment.Application.Interfaces;
using StudentManagment.Infrastructure.Persistence;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using StudentManagment.Domain.Interfaces;
using StudentManagment.Api.BackgroundSync;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddScoped<IAppDbContext, AppDbContext>();

builder.Services.AddHostedService<DatabaseSyncService>();

builder.Services.AddControllers();
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
// HandCrafted By Rohan Thapa || Project Name : AculanProject || Date : 2025-03-03