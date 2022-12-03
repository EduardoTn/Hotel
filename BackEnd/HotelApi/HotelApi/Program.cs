using HotelApi.Data;
using HotelApi.Model;
using HotelApi.Repositories;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ConnectionDbContext>(opts => opts.UseMySql(builder.Configuration.GetConnectionString("HotelPessoaJuridicaConection"), new MySqlServerVersion(new Version(8, 0))));
IServiceCollection serviceCollection = builder.Services.AddScoped<IRepository<HotelPessoaJuridica>, HotelRepository>();
IServiceCollection serviceCollection2 = builder.Services.AddScoped<IRepository<Quarto>, QuartoRepository>();

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
