using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Notes.Application.Interfaces;
using TaskNotissimus.Application.Interfaces;
using TaskNotissimus.Infrastructure.Persistence;
using TaskNotissimus.Infrastructure.Services;

namespace TaskNotissimus.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
            services.AddSingleton<IUriService, UriService>();
            services.AddTransient<IXmlDownloader, XmlDownloader>();
            services.AddTransient<IXmlDeserializer, XmlDeserializer>();
            services.AddTransient<IOfferService, OfferService>();
            return services;
        }
    }
}
