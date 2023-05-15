using ASP.NET_20_02_2023.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_20_02_2023.Controllers
{
    public class AccountController
    {
        private UserManager<AppUser> UserMgr { get; }
        private SignInManager<AppUser> SignInMgr { get; }
        public AccountController(UserManager<AppUser> userMgr, SignInManager<AppUser> signInMgr)
        {
            UserMgr = userMgr;
            SignInMgr = signInMgr;
        }

        public async Task<IActionResult> Register()
        {
            try
            {
                ViewBag.message = "User stworzony";
                AppUser user = await UserMgr.FindByNameAsync("TestUser");
            }
            catch (Exception ex)
            {

                throw;
            }
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
