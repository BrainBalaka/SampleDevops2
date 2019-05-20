///OpenCatapultModelId:6
using AutoMapper;
using SampleDevops.Core.Entities;
using SampleDevops.Areas.Admin.Models;

namespace SampleDevops.Areas.Admin.AutoMapperProfiles
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
