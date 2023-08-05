/*using Profiles;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repository;
using Services;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<ILeadService, LeadService>();
builder.Services.AddScoped<IDbRepository, DbRepository>();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.
        UseNpgsql("host=localhost;port=5432;database=EntityFrameworkLesson;username=postgres;password=root");
});


builder.Services.AddScoped<IDbRepository, DbRepository>();
builder.Services.AddTransient<ILeadService, LeadService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IProductService, ProductService>();

builder.Services.AddSingleton (new UserEntity { Id = Guid.Empty });
builder.Services.AddAutoMapper(typeof(LeadProfile));


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

app.Run();*/
















using Profiles;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repository;
using Services;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<ILeadService, LeadService>();
builder.Services.AddScoped<IDbRepository, DbRepository>();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseNpgsql("host=localhost;port=5432;database=EntityFrameworkLesson;username=postgres;password=root");
});

builder.Services.AddScoped<IDbRepository, DbRepository>();
builder.Services.AddTransient<ILeadService, LeadService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IProductService, ProductService>();

builder.Services.AddSingleton(new UserEntity { Id = Guid.Empty });
builder.Services.AddAutoMapper(typeof(LeadProfile));
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<DataContext>();

    try
    {
        DbInitializer.Initialize(dbContext);
    }
    catch (Exception ex)
    {
        // Обработка ошибок инициализации базы данных
        Console.WriteLine("Ошибка при инициализации базы данных: " + ex.Message);
    }
}

app.Run();
