using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers.Filter;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [UserFilter]
    public class EgitimController : Controller
    {
        private readonly Context _context;
        public EgitimController(Context context)
        {
            _context = context;
        }              
        public IActionResult Index()
        {            
            return View();
        }       

        [HttpGet]
        public IActionResult Kayit()
        {    
            List<SelectListItem> degerler = (from x in _context.Adays.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.AdayAd + " " + x.AdaySoyad + " - " + x.AdayTelefon,
                                                 Value = x.AdayId.ToString()
                                             }).ToList();
            ViewBag.dgr3 = degerler;
            return View();
        }

        [HttpPost]
        public IActionResult Kayit(Egitim e)
        {
            _context.Egitims.Add(e);
            _context.SaveChanges();
            return Redirect("/Index/Index");
        }      

    }
}
