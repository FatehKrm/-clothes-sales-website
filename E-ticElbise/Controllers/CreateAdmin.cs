using BusinesLayer.Abstruct;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace E_ticElbise.Controllers
{
    public class CreateAdmin : Controller
    {
        private readonly IAdminService _adminService;

        public CreateAdmin(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpGet]
        public IActionResult AdminAddIndex()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminAddIndex(Admin admin)
        {
            _adminService.TAdd(admin);
            return RedirectToAction("AdminIndex","Admin");
        }
    }
}
