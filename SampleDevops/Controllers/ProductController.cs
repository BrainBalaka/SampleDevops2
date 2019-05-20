///OpenCatapultModelId:5
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SampleDevops.Core.Entities;
using SampleDevops.Core.Services;
using SampleDevops.Models;

namespace SampleDevops.Controllers
{
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
    }
}
