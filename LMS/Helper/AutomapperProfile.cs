using AutoMapper;
using LMS.DTO;
using LMS.Entities;

namespace LMS.Helper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<RegisterDTO, AppUser>();
        }
    }
}