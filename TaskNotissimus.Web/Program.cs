using Notes.Application.Interfaces;
using System.Reflection;
using TaskNotissimus.Application;
using TaskNotissimus.Application.Common.Mapping;
using TaskNotissimus.Infrastructure;
using TaskNotissimus.Infrastructure.Persistence;
using TaskNotissimus.Web.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(config =>
{
    config.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
    config.AddProfile(new AssemblyMappingProfile(typeof(IApplicationDbContext).Assembly));
    config.AddProfile(new AssemblyMappingProfile(typeof(ApplicationDbContext).Assembly));
});

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseCustomExceptionHandler();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Offer}/{action=Index}/{id?}");

app.Run();
