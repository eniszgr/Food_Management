﻿using Food_Management.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Food_Management.Controllers
{
    public class LoginController : Controller
    {
        Context _context = new Context();
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Error()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Admin p)
        {
            var datavalue = _context.Admins.FirstOrDefault(x => x.AdminName == p.AdminName && x.Password == p.Password);
            if(datavalue != null) {
                var claims = new List<Claim>
                {
                    new Claim (ClaimTypes.Name, p.AdminName)
                };
                var useridentity = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);

                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Category");
            }
            return View();
        }

    }
}
