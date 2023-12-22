using LMS.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LMS.Data
{
	public class Seed
	{
		public static async Task SeedUsers(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
		{
			if (await userManager.Users.AnyAsync()) return;

			var roles = new List<AppRole>{
				new AppRole{Name = "Admin"},
				new AppRole{Name = "Student"},
			};

			foreach (var role in roles)
			{
				await roleManager.CreateAsync(role);
			}

			var admin = new AppUser
			{
				UserName = "admin",
				Email = "sumitpurul@gmail.com"
			};
			var student = new AppUser
			{
				UserName = "student",
				Email = "sumitpurul@gmail.com"
			};
			await userManager.CreateAsync(admin, "Pa$$w0rd");
			await userManager.AddToRoleAsync(admin, "Student");
		}
	}
}
