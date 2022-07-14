using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TestRSD.Models;
using TestRSD.Models.ViewModels;

namespace TestRSD.Controllers
{
    public class AccountController : Controller
    {
        public string ReturnUrl { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController( UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
             
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    Email = registerVM.Email,
                    UserName = new MailAddress(registerVM.Email).User,
                    UserCode = registerVM.UserCode,
                    Masla7aManageCode = registerVM.Masla7aManageCode,
                    Masla7aCode = registerVM.Masla7aCode,
                    OperationsManageCode = registerVM.OperationsManageCode,
                    OperationsManagePass = registerVM.OperationsManagePass,
                    CompanyCode = registerVM.CompanyCode,
                    EmailConfirmed = true,
                    
                };
                var result = await _userManager.CreateAsync(user, registerVM.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "sa7pMasla7a");
                    return RedirectToAction("Login","Account");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            var userName = new EmailAddressAttribute().IsValid(loginVM.Email) ? new MailAddress(loginVM.Email).User : loginVM.Email;
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(userName, loginVM.Password, loginVM.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                
                if (!result.IsLockedOut)
                {
                    ModelState.AddModelError(string.Empty, "البريد الالكتروني و الرقم السري غير متطابقين");
                    return View();
                }
                
            }

            // If we got this far, something failed, redisplay form
            return View();

        }



        //[HttpPost]
        //[Route("Logout")]
        //public async Task<IActionResult> Logout()
        //{
        //    await userService.LogoutAsync();
        //    return Ok("تم تسجيل الخروج");
        //}

    }
}
