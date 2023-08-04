using Controllers;
using Entities;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Models;
using Repository;
using Services;
using System.Diagnostics.Contracts;
using System.Runtime.ConstrainedExecution;
using System.Text.Unicode;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

/*
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IDbRepository, DbRepository>();*/


/*Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        // Регистрация зависимостей
        services.AddTransient<IDbRepository, DbRepository>();
        services.AddTransient<IOrderService, OrderService>();
        services.AddTransient<ILeadService, LeadService>();
        services.AddTransient<IProductService, ProductService>();
    });*/



/*builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddTransient<ILeadService, LeadService>();
builder.Services.AddDbContext<DataContext>(options =>
            options.UseNpgsql("host=localhost;port=5432;database=EntityFrameworkLesson;username=postgres;password=root"));
builder.Services.AddMemoryCache();*/


builder.Services.AddScoped<ILeadService, LeadService>();
builder.Services.AddScoped<IDbRepository, DbRepository>();












builder.Services.AddDbContext<DataContext>(options =>
{
    options.
        UseNpgsql("host=localhost;port=5432;database=EntityFrameworkLesson;username=postgres;password=root");
});

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<IDbRepository, DbRepository>();
builder.Services.AddTransient<ILeadService, LeadService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IProductService, ProductService>();

builder.Services.AddSingleton (new UserEntity { Id = Guid.Empty });
builder.Services.AddAutoMapper(typeof(Profiles.LeadProfile));


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