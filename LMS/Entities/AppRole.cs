using Microsoft.AspNetCore.Identity;

namespace LMS.Entities
{
    public class AppRole : IdentityRole
    {
        public ICollection<AppUserRole> UserRoles { get; set; }   
    }
}