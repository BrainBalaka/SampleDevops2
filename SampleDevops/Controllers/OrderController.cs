///OpenCatapultModelId:4
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SampleDevops.Core.Entities;
using SampleDevops.Core.Services;
using SampleDevops.Models;

namespace SampleDevops.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _orderService.GetOrders();
            var models = _mapper.Map<List<OrderViewModel>>(data);
            return View(models);
        }
    }
}
