///OpenCatapultModelId:4
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SampleDevops.Areas.Admin.Models;
using SampleDevops.Core.Entities;
using SampleDevops.Core.Services;
using SampleDevops.Identity;

namespace SampleDevops.Areas.Admin.Controllers
{
    [Authorize(Policy = AuthorizePolicy.UserRoleAdminAccess)]
    [Area("Admin")]
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

        public IActionResult Create()
        {
            return View(new OrderViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, OrderViewModel model)
        {
            try
            {
                var entity = _mapper.Map<Order>(model);
                await _orderService.CreateOrder(entity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            var data = await _orderService.GetOrderById(id);
            var model = _mapper.Map<OrderViewModel>(data);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, OrderViewModel model)
        {
            try
            {
                var entity = _mapper.Map<Order>(model);
                await _orderService.UpdateOrder(entity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        public IActionResult Delete(int id)
        {
            ViewData["Id"] = id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, OrderViewModel model)
        {
            try
            {
                await _orderService.DeleteOrder(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewData["Id"] = id;
                return View();
            }
        }
    }
}
