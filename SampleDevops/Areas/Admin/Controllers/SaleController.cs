///OpenCatapultModelId:6
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
    public class SaleController : Controller
    {
        private readonly ISaleService _saleService;
        private readonly IMapper _mapper;

        public SaleController(ISaleService saleService, IMapper mapper)
        {
            _saleService = saleService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _saleService.GetSales();
            var models = _mapper.Map<List<SaleViewModel>>(data);
            return View(models);
        }

        public IActionResult Create()
        {
            return View(new SaleViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, SaleViewModel model)
        {
            try
            {
                var entity = _mapper.Map<Sale>(model);
                await _saleService.CreateSale(entity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            var data = await _saleService.GetSaleById(id);
            var model = _mapper.Map<SaleViewModel>(data);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SaleViewModel model)
        {
            try
            {
                var entity = _mapper.Map<Sale>(model);
                await _saleService.UpdateSale(entity);
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
        public async Task<IActionResult> Delete(int id, SaleViewModel model)
        {
            try
            {
                await _saleService.DeleteSale(id);
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
