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
using Autofac.Extensions.DependencyInjection;
using Autofac;
using Business.DependencyResolvers.Autofac;
using GriffonCMS.Infrastructure.Utils.Security.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using GriffonCMS.Infrastructure.Utils.Security.Encryption;
using GriffonCMS.Application.Command.Categories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddMediatR(typeof(CreateCategoryCommandHandler).GetTypeInfo().Assembly);

builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Example Options
//builder.Services.Configure<GriffonEFContextOptions>(options => builder.Configuration.GetConnectionString("GriffonSQLServer"));
//var GriffonSQLServer = "Data Source=ARZU\\SQLEXPRESS; Initial Catalog = Cinephile; Integrated Security = True";
builder.Services.AddDbContext<GriffonEFContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("GriffonSQLServer")));
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutofacBusinessModule());
    });
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder.WithOrigins("http://localhost:3000"));
}
    );

var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = tokenOptions.Issuer,
            ValidAudience = tokenOptions.Audience,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)

        };

    });


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

app.UseCors(builder => builder.WithOrigins("http://localhost:3000").AllowAnyHeader());
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "Admin",
    pattern: "{area:exists}/{controller=Login}/{action=Login}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=StartPage}/{action=Index}/{id?}");

app.Run();
