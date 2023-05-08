using Dev_Email_Management.Domain.Interfaces.Repositories;
using Dev_Email_Management.Domain.Interfaces.Service;
using Dev_Email_Management.Domain.Services;
using Dev_Email_Management.Infrastructure.Persistence.Context;
using Dev_Email_Management.Infrastructure.Repositories;
using Dev_Email_Management.MVC.AutoMapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Criando a connectionString
var conectionString = builder.Configuration.GetConnectionString("DataBase");

builder.Services.AddDbContext<Dev_Email_ManagementContext>(options => 
    options.UseSqlServer(conectionString));

//Injeções de Dependência - Repositories
builder.Services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
builder.Services.AddScoped<IBusinessRepository, BusinessRepository>();
builder.Services.AddScoped<IBusinessCityRepository, BusinessCityRepository>();
builder.Services.AddScoped<IBusinessStateRepository, BusinessStateRepository>();
builder.Services.AddScoped<IBusinessEmailRepository, BusinessEmailRepository>();
builder.Services.AddScoped<IBusinessPhoneRepository, BusinessPhoneRepository>();

//Injeções de dependência - Services
//builder.Services.AddScoped<IBusinessService, BusinessService>();
//builder.Services.AddScoped<IBusinessCityService, BusinessCityService>();
//builder.Services.AddScoped<IBusinessStateService, BusinessStateService>();
//builder.Services.AddScoped<IBusinessEmailService, BusinessEmailService>();
//builder.Services.AddScoped<IBusinessPhoneService, BusinessPhoneService>();

//AutoMapper - todas as confg
builder.Services.AddAutoMapper(typeof(Email_Management_Mapper));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
