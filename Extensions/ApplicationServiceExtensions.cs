using API.Data;
using Microsoft.EntityFrameworkCore;
using MyDatingApp.Interfaces;

namespace MyDatingApp.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, 
            IConfiguration config)
        {
           services.AddDbContext<DataContext>(opt => 
           {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
           });

            // // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            // builder.Services.AddEndpointsApiExplorer();
            // builder.Services.AddSwaggerGen();

            services.AddCors();
            services.AddScoped<ITokenService, TokenService.TokenService>();

            return services;

        }
    }
}