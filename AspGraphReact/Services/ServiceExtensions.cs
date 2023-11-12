using BLL.Interfaces;
using BLL.Services;
using DAL.EF;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Common;

namespace AspGraphReact.Services
{
    public static class ServiceExtensions
    {
        public static void ConfigureDbContext(this IServiceCollection services, string connection)
        {
            services.AddDbContext<MyDbContext>(
                options => options.UseLazyLoadingProxies()
                .UseMySql(connection, new MySqlServerVersion(new Version(
                    Constants.DBVersion.Major,
                    Constants.DBVersion.Minor,
                    Constants.DBVersion.Build
                    ))));
        }

        public static void ConfigureCardInfoService(this IServiceCollection services)
        {
            services.AddScoped<ICardInfoService, CardInfoService>();
        }

        public static void ConfigureUserService(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }

        public static void ConfigureUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
