using Microsoft.AspNetCore.Hosting;
using MediatR;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using System.Runtime;
using GriffonCMS.Infrastructure.Options;
using GriffonCMS.Core.Context.EFContext;
using Microsoft.EntityFrameworkCore;
using GriffonCMS.Application.Utils;
using GriffonCMS.Infrastructure.Registrations;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMediatR(typeof(MediatRAssemblyReference).Assembly);


builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Example Options
//builder.Services.Configure<GriffonEFContextOptions>(options => builder.Configuration.GetConnectionString("GriffonSQLServer"));

builder.Services.AddDbContext<GriffonEFContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("GriffonSQLServer")));

builder.Services.RegisterRepositories();
builder.Services.RegisterAutoMapper();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();
