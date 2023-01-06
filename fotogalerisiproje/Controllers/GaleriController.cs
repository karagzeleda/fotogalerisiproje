using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using fotogalerisiproje.Models;

namespace fotogalerisiproje.Controllers
{
    public class GaleriController : Controller
    {
        // GET: Galeri
        Model1 db = new Model1();
        

        public ActionResult Index()
        {
            var fotograflar = db.FotoOzellikleri.ToList();
            return View(fotograflar);
        }

        [HttpGet]
        public ActionResult FotografEkle()
        {
            return View();

        }

        [HttpPost]
        public ActionResult FotografEkle(FotoOzellikleri t)
        {
            db.FotoOzellikleri.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult FotografSil(int id)
        {
            var fotograf = db.FotoOzellikleri.Find(id);
            db.FotoOzellikleri.Remove(fotograf);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult FotografGetir(int id)
        {
            var ftgrf = db.FotoOzellikleri.Find(id);
            return View("FotografGetir",ftgrf);

        }
        public ActionResult FotografGuncelle(FotoOzellikleri t)
        {
            var fotograf = db.FotoOzellikleri.Find(t.FOTOID);
            fotograf.FOTOAD = t.FOTOAD;
            fotograf.FOTORENK = t.FOTORENK;
            fotograf.FOTOSAHİBİ = t.FOTOSAHİBİ;
            fotograf.KATEGORI= t.KATEGORI;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult GirisYap()
        {

            return View();
        }

    }
}