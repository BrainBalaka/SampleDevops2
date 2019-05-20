///OpenCatapultModelId:4
using AutoMapper;
using SampleDevops.Core.Entities;
using SampleDevops.Models;

namespace SampleDevops.AutoMapperProfiles
{
    public class OrderAutoMapperProfile : Profile
    {
        public OrderAutoMapperProfile()
        {
            CreateMap<Order, OrderViewModel>();

            CreateMap<OrderViewModel, Order>();
        }
    }
}
