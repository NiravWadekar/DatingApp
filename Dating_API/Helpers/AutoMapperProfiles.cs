using System.Linq;
using AutoMapper;
using Dating_API.DTOs;
using Dating_API.Entities;
using Dating_API.Extensions;

namespace Dating_API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
                    .ForMember(dest => dest.PhotoUrl, memberOptions=>
                        memberOptions.MapFrom(sourceMember => sourceMember.Photos.FirstOrDefault(p=>p.IsMain).Url))
                    .ForMember(dest => dest.Age,options => options.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDto>();
        }
    }
}