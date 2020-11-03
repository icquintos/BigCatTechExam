using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BigCatTechExam.Models.Interfaces;
using BigCatTechExam.Models.Models;
using BigCatTechExam.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ias = BigCatTechExam.Services.Interfaces;

namespace BigCatTechExam.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly ias.IAuthenticationService _authenticationService;

        public AdminController(ias.IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewData["IsAuthenticated"] = false;
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme);

            ViewData["IsAuthenticated"] = false;
            return RedirectToAction("Index");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(SiteUserViewModel siteUser)
        {
            if (!_authenticationService.LogginSuccess(new SiteUser(siteUser.UserName, siteUser.Password)))
            {
                return RedirectToAction("Index");
            }

            ViewData["IsAuthenticated"] = true;

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, siteUser.UserName),
                new Claim(ClaimTypes.Role, "Administrator")
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                //AllowRefresh = <bool>,
                // Refreshing the authentication session should be allowed.

                //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                // The time at which the authentication ticket expires. A 
                // value set here overrides the ExpireTimeSpan option of 
                // CookieAuthenticationOptions set with AddCookie.

                //IsPersistent = true,
                // Whether the authentication session is persisted across 
                // multiple requests. When used with cookies, controls
                // whether the cookie's lifetime is absolute (matching the
                // lifetime of the authentication ticket) or session-based.

                //IssuedUtc = <DateTimeOffset>,
                // The time at which the authentication ticket was issued.

                //RedirectUri = <string>
                // The full path or absolute URI to be used as an http 
                // redirect response value.
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            

            return RedirectToAction("Index", "Home");
        }
    }
}