using BusinesLayer.Abstruct;
using DataAccessLayer.Context;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace E_ticElbise.Controllers
{
    public class LoginPageController1 : Controller
    {
        private readonly IAdminService _adminService;

        public LoginPageController1(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpGet]
        public IActionResult LoginPageAdmin()
        {
           
            return View();
        }
        [HttpPost]
        public  IActionResult LoginPageAdmin(Admin admin)
        {    
                return View();       
        }
    }
}
