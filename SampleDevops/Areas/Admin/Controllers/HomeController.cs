using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SampleDevops.Identity;

namespace SampleDevops.Areas.Admin.Controllers
{
    [Authorize(Policy = AuthorizePolicy.UserRoleAdminAccess)]
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
