using GalloFlix.DataTransferObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GalloFlix.Controllers;
[Authorize(Roles = "Administrador")]
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


[HttpGet]
[AllowAnonymous]
            public IActionResult Login(string returnUrl)
        {
            LoginDto login = new();
            login.ReturnUrl = returnUrl ?? Url.Content("~/");
            return View(login);
        }

        [HttpPost]
        public IActionResult Login()
        {
            return View();
        }

    }

