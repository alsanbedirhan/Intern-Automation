using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers.Filter;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [UserFilter]
    public class DeneyimController : Controller
    {
        private readonly Context _context;
        public DeneyimController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeneyimKayit()
        {            
            List<SelectListItem> degerler = (from x in _context.Adays.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.AdayAd + " " + x.AdaySoyad + " - " + x.AdayTelefon,
                                                 Value = x.AdayId.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public IActionResult DeneyimKayit(Deneyim d)
        {
            _context.Deneyims.Add(d);
            _context.SaveChanges();
            return Redirect("/Index/Index");
        }
    }
}
