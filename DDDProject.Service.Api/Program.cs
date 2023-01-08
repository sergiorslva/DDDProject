using AutoMapper;
using DDDProject.Application.Mapper;
using DDDProject.Infra.Data.Repositories;
using DDDProject.Infra.IoC;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
DependencyInjector.Register(builder.Services);

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new EntityMapper());
});

builder.Services.AddDbContext<DDDPRojectContext>(options =>
{    
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));
});


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
