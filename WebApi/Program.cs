using System.Reflection;
using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.Autofac;
using GriffonCMS.Application.Command.Abouts;
using GriffonCMS.Application.Command.Blogs;
using GriffonCMS.Application.Command.Categories;
using GriffonCMS.Application.Command.Comments;
using GriffonCMS.Application.Command.Contacts;
using GriffonCMS.Application.Command.Interests;
using GriffonCMS.Application.Command.Projects;
using GriffonCMS.Application.Command.References;
using GriffonCMS.Application.Command.Skills;
using GriffonCMS.Application.Command.Users;
using GriffonCMS.Application.Command.WorkExperiences;
using GriffonCMS.Core.Context.EFContext;
using GriffonCMS.Infrastructure.Command.Users;
using GriffonCMS.Infrastructure.Registrations;
using GriffonCMS.Infrastructure.Utils.Security.Encryption;
using GriffonCMS.Infrastructure.Utils.Security.Jwt;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

//CREATE
builder.Services.AddMediatR(typeof(CreateCategoryCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(CreateBlogCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(CreateCommentCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(CreateContactCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(CreateInterestCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(CreateProjectCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(CreateReferenceCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(CreateSkillCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(CreateUserCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(CreateWorkExperienceCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(CreateAboutCommandHandler).GetTypeInfo().Assembly);

//DELETE
builder.Services.AddMediatR(typeof(DeleteCategoryByIdCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteBlogByIdCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteCommentByIdCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteContactByIdCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteInterestByIdCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteProjectByIdCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteReferenceByIdCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteSkillByIdCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteUserByIdCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteWorkExperienceByIdCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteAboutByIdCommandHandler).GetTypeInfo().Assembly); 

//UPDATE
builder.Services.AddMediatR(typeof(UpdateUserCommandHandler).GetTypeInfo().Assembly); 
builder.Services.AddMediatR(typeof(UpdateAboutCommandHandler).GetTypeInfo().Assembly); 
builder.Services.AddMediatR(typeof(UpdateBlogCommandHandler).GetTypeInfo().Assembly); 
builder.Services.AddMediatR(typeof(UpdateCategoryCommandHandler).GetTypeInfo().Assembly); 
builder.Services.AddMediatR(typeof(UpdateCommentCommandHandler).GetTypeInfo().Assembly); 
builder.Services.AddMediatR(typeof(UpdateContactCommandHandler).GetTypeInfo().Assembly); 
builder.Services.AddMediatR(typeof(UpdateInterestCommandHandler).GetTypeInfo().Assembly); 
builder.Services.AddMediatR(typeof(UpdateProjectCommandHandler).GetTypeInfo().Assembly); 
builder.Services.AddMediatR(typeof(UpdateReferenceCommandHandler).GetTypeInfo().Assembly); 
builder.Services.AddMediatR(typeof(UpdateSkillCommandHandler).GetTypeInfo().Assembly); 
builder.Services.AddMediatR(typeof(UpdateWorkExperienceCommandHandler).GetTypeInfo().Assembly);  

builder.Services.AddMediatR(typeof(AddCategoryToBlogCommandHandler).GetTypeInfo().Assembly);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.RegisterAutoMapper();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",new OpenApiInfo { Title = "DemoJWT", Version="v1"});
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Jwt Authorization",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[] { }
        }
    });
});
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
        options.TokenValidationParameters = new TokenValidationParameters
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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c=>c.SwaggerEndpoint("/swagger/v1/swagger.json","DemoJWTToken v1"));

}
app.UseCors(builder => builder.WithOrigins("http://localhost:3000").AllowAnyHeader());
app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();