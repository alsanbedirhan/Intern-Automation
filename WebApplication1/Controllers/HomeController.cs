using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Controllers.Filter;

namespace WebApplication1.Controllers
{
    [UserFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //private readonly Context _context;
        //public HomeController(Context context)
        //{
        //    _context = context;
        //}
        public IActionResult Index()
        {
            /*var ad = "ahnmet";
            var soyad = "mehmet";
            var bolum = "yaz staı";

            List<AdaylarViewModel> adaylar = (from x in _context.Adays
                                              select new AdaylarViewModel
                                              {
                                                  AdayAdiSoyadi = x.AdayAd + " " + x.AdaySoyad,
                                                  BasvuruBolumu = _context.Ilans.FirstOrDefault(y => y.IlanID == _context.Basvurus.FirstOrDefault(a => a.AdayID == x.AdayId).IlanID).IlanAciklama
                                              }).ToList();*/

            //using (var _context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<Context>()))

            //var qq = from bsv in _context.Basvurus
            //         join ilan in _context.Ilans on bsv.IlanID equals ilan.IlanID
            //         join aday in _context.Adays on bsv.AdayID equals aday.AdayId
            //         select new AdaylarViewModel { AdayAdiSoyadi = aday.AdayAd + " " + aday.AdaySoyad, BasvuruBolumu = ilan.IlanAciklama };

            //var qq = _context.Adays.Select(a => new AdaylarViewModel { AdayAdiSoyadi = a.AdayAd + " " + a.AdaySoyad, BasvuruBolumu = a.AdayEmail }).ToList();






            //var model = new AdaylarViewModel();
            //model.AdayAdiSoyadi = ad + " " + soyad;
            //model.BasvuruBolumu = bolum;





            //return View(qq.ToList());
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
