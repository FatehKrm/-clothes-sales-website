using BusinesLayer.Abstruct;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace E_ticElbise.Controllers
{
    public class AdminList : Controller
    {
        private readonly IAdminService _adminService;

        public AdminList(IAdminService adminService)
        {
            _adminService = adminService;
        }
        public IActionResult AdminListIndex()
        {
            var values = _adminService.TGetAll();
            return View(values);
        }
        public IActionResult DeleteAdminFromList(int id)
        {
            _adminService.TDelete(id);
            return RedirectToAction("AdminListIndex");      
        }
        [HttpGet]
        public IActionResult EditAdmin(int id)
        {
            var values = _adminService.TgetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAdmin(Admin admin)
        {
            var existingAdmin = _adminService.TgetById(admin.AdminId);
            if (existingAdmin == null)
            {
                return NotFound("Admin bulunamadı.");
            }

            existingAdmin.Name = admin.Name;
            existingAdmin.LastName = admin.LastName;
            existingAdmin.MailAdress = admin.MailAdress;
            existingAdmin.Birth = admin.Birth;
            existingAdmin.Adress = admin.Adress;
            existingAdmin.PhoneNumber = admin.PhoneNumber;
            existingAdmin.PassWord = admin.PassWord;

            _adminService.TUpdate(existingAdmin);
            return RedirectToAction("AdminListIndex");

        }

    }
}
