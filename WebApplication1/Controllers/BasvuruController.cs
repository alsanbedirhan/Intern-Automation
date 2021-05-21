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
    public class BasvuruController : Controller
    {
        private readonly Context _context;
        public BasvuruController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var qq = from bsv in _context.Basvurus
                     join basvur in _context.Basvurus on bsv.BasvuruID equals basvur.BasvuruID
                     join ilan in _context.Ilans on bsv.IlanID equals ilan.IlanID
                     join aday in _context.Adays on bsv.AdayID equals aday.AdayId                     
                     select new AdaylarViewModel { AdayAdiSoyadi = aday.AdayAd + " " + aday.AdaySoyad, BasvuruBolumu = ilan.IlanAciklama,BasvurID=basvur.BasvuruID };
            return View(qq.ToList());            
        }
        [HttpGet]
        public IActionResult Basvuru()
        {            
            List<SelectListItem> degerler = (from x in _context.Adays.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.AdayAd + " " + x.AdaySoyad + " - " + x.AdayTelefon,
                                                 Value = x.AdayId.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;

            List<SelectListItem> degerler2 = (from x in _context.Ilans.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.IlanAciklama,
                                                 Value = x.IlanID.ToString()
                                             }).ToList();
            ViewBag.dgr2 = degerler2;
            return View();           
        }
        [HttpPost]
        public IActionResult Basvuru(Basvuru b)
        {
            _context.Basvurus.Add(b);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BasvuruSil(int id)
        {
            var dep = _context.Basvurus.Find(id);
            _context.Basvurus.Remove(dep);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
