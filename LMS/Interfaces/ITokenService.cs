using LMS.Entities;

namespace LMS.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);

    }
}