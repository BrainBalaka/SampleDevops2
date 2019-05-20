///OpenCatapultModelId:2
using AutoMapper;
using SampleDevops.Core.Entities;
using SampleDevops.Models;

namespace SampleDevops.AutoMapperProfiles
{
    public class CategoryAutoMapperProfile : Profile
    {
        public CategoryAutoMapperProfile()
        {
            CreateMap<Category, CategoryViewModel>();

            CreateMap<CategoryViewModel, Category>();
        }
    }
}
