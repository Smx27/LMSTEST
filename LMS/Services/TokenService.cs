using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.Entities;
using LMS.Interfaces;

namespace LMS.Services
{
    public class TokenService : ITokenService
    {
        public Task<string> CreateToken(AppUser user)
        {
            throw new NotImplementedException();
        }
    }
}