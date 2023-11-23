using Domain.Models.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Clinica_UPQROO.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AspNetUser> _userManager;
        private readonly SignInManager<AspNetUser> _signInManager;

        public AccountController(UserManager<AspNetUser> userManager, SignInManager<AspNetUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string pass) {

            var user = _userManager.FindByEmailAsync(email).Result;

            if (user != null)
            {
                var result = _signInManager.PasswordSignInAsync(user, pass,false,false).Result;

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }


            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }


        public string SeedUser()
        {
            AspNetUser user = new AspNetUser() {
                Email = "jm.torres1592@gmail.com",
                UserName = "jm.torres1592@gmail.com"
            };

            var result = _userManager.CreateAsync(user,"Password1.").Result;

            if (result.Succeeded)
            {
                return "Exito";
            }
            else
            {
                return "Falló";
            }
        }
    }
}
