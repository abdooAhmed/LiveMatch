

using GpProject.ViewModels;


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnMatch.Data;
using OnMatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GpProject.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;
        

        public AccountController(UserManager<User> userMngr, SignInManager<User> signInMngr)
        {
            userManager = userMngr;
            signInManager = signInMngr;
            
           
        }
        [Authorize]
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationViewModel registrationViewModel)
        {
            
            if (ModelState.IsValid)
            {
                
                var user = new User
                {
                    UserName = registrationViewModel.UserName,
                    
                    Email = registrationViewModel.Email,
                    PhoneNumber = registrationViewModel.Phone,
                    
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(user, registrationViewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("AddLeague", "Manage");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }


            }
            
            return View(registrationViewModel);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var User = await userManager.FindByEmailAsync(loginViewModel.Email);
                var result = await signInManager.PasswordSignInAsync(User,loginViewModel.Password,isPersistent:loginViewModel.RememberMe,lockoutOnFailure:false);
                if (result.Succeeded)
                {
                    
                    await userManager.UpdateAsync(User);
                    if (!string.IsNullOrEmpty(loginViewModel.ReturnUrl) &&Url.IsLocalUrl(loginViewModel.ReturnUrl))
                    {
                        return Redirect(loginViewModel.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Matches", "Home");
                    }
                }

            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            var User = await userManager.GetUserAsync(this.User);
            
            await userManager.UpdateAsync(User);
            await signInManager.SignOutAsync();
            return RedirectToAction("Matches", "Home");
        }




    }
}
