using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers.Filter;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [UserFilter]
    public class IlanController : Controller
    {
        private readonly Context _context;
        public IlanController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IlanGoster()
        {
            var degerler = _context.Ilans.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniIlan()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniIlan(Ilan i)
        {
            _context.Ilans.Add(i);
            _context.SaveChanges();
            return RedirectToAction("IlanGoster");
        }
        public IActionResult IlanSil(int id)
        {
            var dep = _context.Ilans.Find(id);
            _context.Ilans.Remove(dep);
            _context.SaveChanges();
            return RedirectToAction("IlanGoster");
        }
        public IActionResult IlanGetir(int id)
        {
            var ilan = _context.Ilans.Find(id);
            return View(ilan);
        }
        public IActionResult IlanGuncelle(Ilan i)
        {
            var change = _context.Ilans.Find(i.IlanID);
            change.IlanAciklama = i.IlanAciklama;
            change.IlanAktifMi = i.IlanAktifMi;
            change.IlanBaslangicTarihi = i.IlanBaslangicTarihi;
            change.IlanBitisTarihi = i.IlanBitisTarihi;          
            _context.SaveChanges();
            return RedirectToAction("IlanGoster");
        }
    }
}
