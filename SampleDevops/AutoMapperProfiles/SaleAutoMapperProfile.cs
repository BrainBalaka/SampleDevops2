///OpenCatapultModelId:6
using AutoMapper;
using SampleDevops.Core.Entities;
using SampleDevops.Models;

namespace SampleDevops.AutoMapperProfiles
{
    public class SaleAutoMapperProfile : Profile
    {
        public SaleAutoMapperProfile()
        {
            CreateMap<Sale, SaleViewModel>();

            CreateMap<SaleViewModel, Sale>();
        }
    }
}
