using WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers.Filter;

namespace WebApplication1.Controllers
{    
    public class LoginController : Controller
    {
        private readonly Context _context;
        public LoginController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Gir(string kullanici, string sifre)
        {
            var user = _context.Admins.FirstOrDefault(x => x.Kullanici.Equals(kullanici) && x.Sifre.Equals(sifre));
            if (user != null)
            {
                HttpContext.Session.SetInt32("id", user.AdminID);
                HttpContext.Session.SetString("fullname", user.Ad+" "+user.Soyad);           
                return Redirect("/Index/Index");
            }
            return Redirect("Index");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/Login/Index");
        }
    }
}
