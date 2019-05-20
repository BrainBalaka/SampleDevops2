///OpenCatapultModelId:2
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
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _categoryService.GetCategories();
            var models = _mapper.Map<List<CategoryViewModel>>(data);
            return View(models);
        }

        public IActionResult Create()
        {
            return View(new CategoryViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, CategoryViewModel model)
        {
            try
            {
                var entity = _mapper.Map<Category>(model);
                await _categoryService.CreateCategory(entity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            var data = await _categoryService.GetCategoryById(id);
            var model = _mapper.Map<CategoryViewModel>(data);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CategoryViewModel model)
        {
            try
            {
                var entity = _mapper.Map<Category>(model);
                await _categoryService.UpdateCategory(entity);
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
        public async Task<IActionResult> Delete(int id, CategoryViewModel model)
        {
            try
            {
                await _categoryService.DeleteCategory(id);
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
