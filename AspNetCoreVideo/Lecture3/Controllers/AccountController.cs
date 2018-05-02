using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lecture3.Data.Entities;
using Lecture3.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lecture3.Controllers
{
    public class AccountController : Controller
    {

        UserManager<User> userMgr;
        SignInManager<User> signInMgr;

        public AccountController(UserManager<User> userMgr, SignInManager<User> signInMgr)
        {
            this.userMgr = userMgr;
            this.signInMgr = signInMgr;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(RegisterVM model)
        {
            var result = await signInMgr.PasswordSignInAsync(model.UserName, model.Password, false, false);

            if (result.Succeeded)
                return RedirectToAction("Index", "Member");
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = new User { UserName = model.UserName };
            var result = await userMgr.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await signInMgr.SignInAsync(user, false);
                return RedirectToAction("Index", "Member");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View();
        }

    }
}
