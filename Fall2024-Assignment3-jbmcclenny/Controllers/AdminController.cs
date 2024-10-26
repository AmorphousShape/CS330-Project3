using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Fall2024_Assignment3_jbmcclenny.Data;
using Fall2024_Assignment3_jbmcclenny.Models;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace Fall2024_Assignment3_jbmcclenny.Controllers {
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller {

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string username, string password)
        {
            // Retrieve the stored credentials from secrets
            var storedUsername = _configuration["AdminCredentials:Username"];
            var storedPassword = _configuration["AdminCredentials:Password"];

            // Validate the provided credentials
            if (username == storedUsername && password == storedPassword)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim(ClaimTypes.Role, "Admin")
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                return RedirectToAction("Index", "Admin");
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View();
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Admin");
        }
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public AdminController(ApplicationDbContext context, IConfiguration configuration) {
            _context = context;
            _configuration = configuration;
            _context = context;
        }

        public async Task<IActionResult> Index() {
            return View(await _context.Actors.ToListAsync());
        }

        public IActionResult Create() {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(CreatePageViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.PageType == "Actor")
                {
                    _context.Add(model.Actor);
                }
                else if (model.PageType == "Movie")
                {
                    _context.Add(model.Movie);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}