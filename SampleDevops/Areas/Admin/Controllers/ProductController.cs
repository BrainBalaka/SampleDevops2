///OpenCatapultModelId:5
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
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _productService.GetProducts();
            var models = _mapper.Map<List<ProductViewModel>>(data);
            return View(models);
        }

        public IActionResult Create()
        {
            return View(new ProductViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, ProductViewModel model)
        {
            try
            {
                var entity = _mapper.Map<Product>(model);
                await _productService.CreateProduct(entity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            var data = await _productService.GetProductById(id);
            var model = _mapper.Map<ProductViewModel>(data);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductViewModel model)
        {
            try
            {
                var entity = _mapper.Map<Product>(model);
                await _productService.UpdateProduct(entity);
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
        public async Task<IActionResult> Delete(int id, ProductViewModel model)
        {
            try
            {
                await _productService.DeleteProduct(id);
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
