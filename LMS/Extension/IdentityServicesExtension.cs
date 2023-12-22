using LMS.Data;
using LMS.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace LMS.Extension
{
	public static class IdentityServicesExtension
	{
		public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config) 
		{
			//Added Microsoft Identity service
			services.AddIdentityCore<AppUser>(opt => {
				opt.Password.RequireNonAlphanumeric = false;
			})
				.AddRoles<AppRole>()
				.AddRoleManager<RoleManager<AppRole>>()
				.AddEntityFrameworkStores<DataContext>();
			//Barrier config
			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
				.AddJwtBearer(options =>
				{
					options.TokenValidationParameters = new TokenValidationParameters
					{
						ValidateIssuerSigningKey = true,
						IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"])),
						ValidateIssuer = false,
						ValidateAudience = false
					};

					options.Events = new JwtBearerEvents
					{
						OnMessageReceived = context => {
							var accessToken = context.Request.Query["access_token"];

							var path = context.HttpContext.Request.Path;

							if (!string.IsNullOrEmpty(accessToken) && path.StartsWithSegments("/hubs"))
							{
								context.Token = accessToken;
							}

							return Task.CompletedTask;
						}
					};
				}
			);

			//Adding policy to the application
			services.AddAuthorization(opt => {
				opt.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
				opt.AddPolicy("ModeratePhotoRole", policy => policy.RequireRole("Admin", "Moderate"));
			});

			return services;
		}
	}
}
