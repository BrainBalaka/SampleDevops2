///OpenCatapultModelId:1
using AutoMapper;
using SampleDevops.Core.Entities;
using SampleDevops.Areas.Admin.Models;

namespace SampleDevops.Areas.Admin.AutoMapperProfiles
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
