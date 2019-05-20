///OpenCatapultModelId:5
using AutoMapper;
using SampleDevops.Core.Entities;
using SampleDevops.Areas.Admin.Models;

namespace SampleDevops.Areas.Admin.AutoMapperProfiles
{
    public class ProductAutoMapperProfile : Profile
    {
        public ProductAutoMapperProfile()
        {
            CreateMap<Product, ProductViewModel>();

            CreateMap<ProductViewModel, Product>();
        }
    }
}
