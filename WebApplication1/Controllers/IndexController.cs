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
    [UserFilter]
    public class IndexController : Controller
    {
        private readonly Context _context;
        public IndexController(Context context)
        {
            _context = context;
        }      

        public IActionResult Index()
        {
            var degerler = _context.Adays.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniAday()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniAday(Aday a)
        {
            _context.Adays.Add(a);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AdaySil(int id)
        {
            var dep = _context.Adays.Find(id);
            _context.Adays.Remove(dep);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Ilan(int id)
        {
            var qq = from bsv in _context.Basvurus
                     join ilan in _context.Ilans on bsv.IlanID equals ilan.IlanID
                     join aday in _context.Adays on bsv.AdayID equals aday.AdayId
                     where aday.AdayId == id
                     select new AdaylarViewModel { AdayAdiSoyadi = aday.AdayAd + " " + aday.AdaySoyad, BasvuruBolumu = ilan.IlanAciklama };
            return View(qq.ToList());
        }
        public IActionResult Egitim(int id)
        {
            var qq = from bsv in _context.Egitims
                     join aday in _context.Adays on bsv.AdayID equals aday.AdayId
                     where aday.AdayId == id
                     select new EgitimViewModel { AdayAdSoyad = aday.AdayAd + " " + aday.AdaySoyad, Durum = bsv.EgitimDurumu, Baslangic = bsv.BaslangicTarihi, Bitis = bsv.BitisTarihi, Bolum = bsv.BolumAdi, Okul = bsv.OkulAdi };
            return View(qq.ToList());
        }
        public IActionResult Deneyim(int id)
        {
            var qq = from bsv in _context.Deneyims
                     join aday in _context.Adays on bsv.AdayID equals aday.AdayId
                     where aday.AdayId == id
                     select new DeneyimViewModel { AdayAdSoyad = aday.AdayAd + " " + aday.AdaySoyad, Firma = bsv.FirmaAdi, Pozisyonu = bsv.Pozisyon, Baslangic = bsv.BaslangicTarihi, Bitis = bsv.BitisTarihi };
            return View(qq.ToList());
        }
        public IActionResult AdayGetir(int id)
        {
            var aday = _context.Adays.Find(id);
            return View("AdayGetir", aday);
        }
        public IActionResult AdayGuncelle(Aday a)
        {
            var change = _context.Adays.Find(a.AdayId);
            change.AdayAd = a.AdayAd;
            change.AdaySoyad = a.AdaySoyad;
            change.AdayAdres = a.AdayAdres;
            change.AdayDogumTarihi = a.AdayDogumTarihi;
            change.AdayEmail = a.AdayEmail;
            change.AdayTelefon = a.AdayTelefon;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
