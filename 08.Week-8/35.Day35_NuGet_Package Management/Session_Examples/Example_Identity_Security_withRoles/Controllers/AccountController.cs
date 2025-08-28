using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
  SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel  model)
        {

            if (!ModelState.IsValid) return View(model);

            var user = new IdentityUser() { UserName = model.UserName, Email = model.Email };

            //  Create New User
            var result = await _userManager.CreateAsync(user, model.Password);



            if (result.Succeeded)
            {
                // Assign role to User
                await _userManager.AddToRoleAsync(user, "User");

                // User Loggedin                 
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
                
                // return RedirectToAction("Account", "Login");
            }


            return View(model);
        }

        [HttpGet] 
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);


            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, true);

            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(model.ReturnUrl))
                {
                    return Redirect(model.ReturnUrl);
                }
                else
                {
                   return RedirectToAction("Index", "Home");
                }

            }


            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult>  Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
           // return RedirectToAction("Login", "Account");
        }


        [HttpGet]
        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }
    }
}
