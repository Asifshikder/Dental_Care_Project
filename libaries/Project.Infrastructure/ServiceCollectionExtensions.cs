using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System;
using Project.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Project.Infrastructure.DataAccess;
using Microsoft.AspNetCore.Identity;
using Project.Core.Domain.Authentication;
using Project.Infrastructure.Settings;
using System.Reflection;

namespace Project.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("constring"));
                option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }, ServiceLifetime.Transient);
            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddSingleton<ISqlService, SqlService>();


            SqlProperties sqlProperties = new SqlProperties()
            {
                DatabaseName = Assembly.GetAssembly(typeof(ApplicationDbContext)).FullName,
                ConnectionString = configuration.GetConnectionString("constring")
            };
            services.AddSingleton(sqlProperties);
            return services;
        }
    }
}