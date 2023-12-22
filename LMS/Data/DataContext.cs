using LMS.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LMS.Data
{
	public class DataContext : IdentityDbContext<AppUser, AppRole, int,
	IdentityUserClaim<int>, AppUserRole,
	IdentityUserLogin<int>, IdentityRoleClaim<int>,
	IdentityUserToken<int>>
	{
		public DataContext(DbContextOptions options) :base(options)
		{
			
		}
	}
}
