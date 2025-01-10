using Microsoft.AspNetCore.Mvc;

namespace IdentityAuth.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AccountController : Controller
    {
        // Action cho trang đăng ký
        public IActionResult Register()
        {
            return View("/Areas/Identity/Pages/Account/Register.cshtml");
        }
        // Action cho trang đăng nhập
        public IActionResult Login()
        {
            return View("/Areas/Identity/Pages/Account/Login.cshtml");
        }
    }
}
