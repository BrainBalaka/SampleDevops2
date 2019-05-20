///OpenCatapultModelId:5
using AutoMapper;
using SampleDevops.Core.Entities;
using SampleDevops.Models;

namespace SampleDevops.AutoMapperProfiles
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
