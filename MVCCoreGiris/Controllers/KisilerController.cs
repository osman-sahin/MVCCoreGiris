using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreGiris.Models;
using MVCCoreGiris.Services;

namespace MVCCoreGiris.Controllers
{
    public class KisilerController : Controller
    {
        private readonly OkulContext db;

        public KisilerController(OkulContext okulContext)
        {
            this.db = okulContext;
        }
        public IActionResult Index()
        {
            return View(db.Kisiler.ToList());
        }
        public IActionResult Yeni()
        {
            var lns = (LuckyNumberService)HttpContext.RequestServices.GetService(typeof(LuckyNumberService));  ///////
            ViewBag.SansliSayi = lns.LuckyNumber;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Yeni(Kisi kisi)
        {
            if (ModelState.IsValid)
            {
                db.Add(kisi); //db.kisiler.add(kisi);
                db.SaveChanges();
                TempData["mesaj"] = $"\"{kisi.KisiAd}\" adlı kişi başarıyla eklendi.";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Duzenle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var kisi = db.Kisiler.Find(id);

            if (kisi == null)
            {
                return NotFound();
            }
            return View(kisi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Duzenle(Kisi kisi)
        {
            if (ModelState.IsValid)
            {
                // db.Entry(kisi).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.Update(kisi); //db.kisiler.add(kisi);
                db.SaveChanges();
                TempData["mesaj"] = $"\"{kisi.KisiAd}\" adlı kişi başarıyla düzenlendi.";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Sil(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var kisi = db.Kisiler.Find(id);

            if (kisi == null)
            {
                return NotFound();
            }

            db.Remove(kisi);
            db.SaveChanges();
            TempData["mesaj"] = $"\"{kisi.KisiAd}\" adlı kişi başarıyla silindi.";
            return RedirectToAction(nameof(Index));
        }
    }
}