///OpenCatapultModelId:2
using AutoMapper;
using SampleDevops.Core.Entities;
using SampleDevops.Areas.Admin.Models;

namespace SampleDevops.Areas.Admin.AutoMapperProfiles
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
