using Siparis.BusinessLogic.Abstract;
using Siparis.Entity;
using Siparis.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Siparis.MvcWebUI.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun

        private IUrunServices urun_services { get; set; }

        public UrunController(IUrunServices urun_Services)
        {
            this.urun_services = urun_Services;
        }



        public ActionResult UrunAnaSayfa()
        {
            var model = new EntityListModel
            {
                Urunler=urun_services.GetAll()
            };

            return View(model);
        }


        public ActionResult Guncelleme(Urun urun,Barkod barkod)
        {
            var model = new EntityModel
            {
                urun = urun,
                barkod = barkod
            };

            return View(model);
        }

        public ActionResult Ekleme(Urun urun, Barkod barkod)
        {
            var model = new EntityModel
            {
                urun = urun,
                barkod = barkod
            };

            return View(model);
        }

        public ActionResult Silme(Urun urun, Barkod barkod)
        {
            var model = new EntityModel
            {
                urun = urun,
                barkod = barkod
            };

            return View(model);
        }

    }
}