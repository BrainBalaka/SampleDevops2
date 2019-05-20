///OpenCatapultModelId:2
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SampleDevops.Core.Entities;
using SampleDevops.Core.Services;
using SampleDevops.Models;

namespace SampleDevops.Controllers
{
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
    }
}
