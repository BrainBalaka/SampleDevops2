///OpenCatapultModelId:6
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SampleDevops.Core.Entities;
using SampleDevops.Core.Services;
using SampleDevops.Models;

namespace SampleDevops.Controllers
{
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
    }
}
