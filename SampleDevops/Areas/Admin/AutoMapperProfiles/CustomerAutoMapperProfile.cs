///OpenCatapultModelId:3
using AutoMapper;
using SampleDevops.Core.Entities;
using SampleDevops.Areas.Admin.Models;

namespace SampleDevops.Areas.Admin.AutoMapperProfiles
{
    public class CustomerAutoMapperProfile : Profile
    {
        public CustomerAutoMapperProfile()
        {
            CreateMap<Customer, CustomerViewModel>();

            CreateMap<CustomerViewModel, Customer>();
        }
    }
}
