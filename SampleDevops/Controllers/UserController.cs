///OpenCatapultModelId:1
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SampleDevops.Core.Entities;
using SampleDevops.Core.Services;
using SampleDevops.Models;

namespace SampleDevops.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _userService.GetUsers();
            var models = _mapper.Map<List<UserViewModel>>(data);
            return View(models);
        }
    }
}
