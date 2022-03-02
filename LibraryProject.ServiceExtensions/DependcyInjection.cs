using LibraryProject.Data;
using LibraryProject.Repositories.Contracts;
using LibraryProject.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryProject.ServiceExtensions
{
    public static class DependcyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IBookRepository), typeof(BookRepository));
            services.AddScoped(typeof(IBookReservationRepository), typeof(BookReservationRepository));
            services.AddScoped(typeof(IBookReservationHistoryRepository), typeof(BookReservationHistoryRepository));

            return services;
        }

        public static void ConfigureSqlServer(this IServiceCollection services, IConfiguration configuration) =>
         services.AddDbContext<ApplicationContextDb>(options =>
         options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
    }
}
