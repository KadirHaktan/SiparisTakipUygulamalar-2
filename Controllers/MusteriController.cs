using Siparis.BusinessLogic.Abstract;
using Siparis.BusinessLogic.DepencyInjection_Tools;
using Siparis.Entity;
using Siparis.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Siparis.MvcWebUI.Controllers
{
    public class MusteriController : Controller
    {

        private IMusteriServices _musteriServices { get; set; }

        public MusteriController(IMusteriServices services)
        {
          this._musteriServices = services;
        }

        


        


        // GET: Musteri
        public ActionResult MusteriAnaSayfa()
        {
            var model = new EntityListModel
            {
                Musteriler = _musteriServices.GetAllCustomers()       
            };


            return View(model);
        }

        
        public ActionResult Ekleme(Musteri _musteri,Telefon _telefon)
        {
            var model = new EntityModel
            {
                musteri = _musteri,
                telefon = _telefon
            };

            return View(model);
        }


        public ActionResult Silme(Musteri _musteri,Telefon _telefon)
        {
            var model = new EntityModel
            {
                musteri = _musteri,
                telefon = _telefon
            };

            return View(model);
        }

        public ActionResult Guncelleme(Musteri _musteri, Telefon _telefon)
        {
            var model = new EntityModel
            {
                musteri = _musteri,
                telefon = _telefon
            };

            ViewBag.Musteriler = _musteriServices.GetAllCustomers();
            ViewBag.Telefonlar = _musteriServices.GetAllPhones();

            return View(model);
        }


        [HttpPost]
        public ActionResult MusteriEkleme(Musteri musteri,Telefon telefon)
        {
            _musteriServices.TransactionalAdd(musteri, telefon);

            return RedirectToAction("MusteriAnaSayfa");
        }

        public ActionResult MusteriGuncelleme(Musteri musteri,Telefon telefon)
        {
            _musteriServices.TransactionalUpdate(musteri, telefon);

            return RedirectToAction("MusteriAnaSayfa");
        }

        public ActionResult MusteriSilme(Musteri musteri,Telefon telefon)
        {
            _musteriServices.TransactionalDelete(telefon,musteri);

            return RedirectToAction("MusteriAnaSayfa");
        }
       
    



    }
}