///OpenCatapultModelId:1
using AutoMapper;
using SampleDevops.Core.Entities;
using SampleDevops.Models;

namespace SampleDevops.AutoMapperProfiles
{
    public class UserAutoMapperProfile : Profile
    {
        public UserAutoMapperProfile()
        {
            CreateMap<User, UserViewModel>();

            CreateMap<UserViewModel, User>();
        }
    }
}
