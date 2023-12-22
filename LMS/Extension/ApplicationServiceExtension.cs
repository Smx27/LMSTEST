using LMS.Data;
using LMS.Interfaces;
using LMS.Services;
using Microsoft.EntityFrameworkCore;

namespace LMS.Extension
{
	public static class ApplicationServiceExtension
	{
		public static IServiceCollection ApplicationServices(this IServiceCollection services, IConfiguration config)
		{
			 services.AddDbContext<DataContext>(opt => 
            {
                opt.UseSqlite(config.GetConnectionString("Default"));
            });
			services.AddScoped<ITokenService, TokenService>();
			services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

			return services;
		}
	}
}
