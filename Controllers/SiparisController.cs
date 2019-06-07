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
    public class SiparisController : Controller
    {
        
        private ISiparisServices siparis_Services { get; set; }

        public SiparisController(ISiparisServices services)
        {
            this.siparis_Services = services;
        }

        public ActionResult SiparisAnaSayfa()
        {
            var model = new EntityListModel
            {
                Siparisler = siparis_Services.GetAll()
            };


            return View(model);
        }


        public ActionResult Ekleme(_Siparis siparis)
        {
            var model = new EntityModel
            {
                siparis = siparis
            };

            return View(model);
        }


        public ActionResult Silme(_Siparis siparis)
        {
            var model = new EntityModel
            {
                siparis = siparis
            };

            return View(model);
        }

        
        public ActionResult Guncelleme(_Siparis siparis)
        {
            var model = new EntityModel
            {
                siparis = siparis
            };

            return View(model);
        }



        [HttpPost]
        public ActionResult SiparisEkle(_Siparis siparis)
        {
            siparis_Services.Add(siparis);

            return RedirectToAction("SiparisAnaSayfa");
        }

        public ActionResult SiparisGuncelle(_Siparis siparis)
        {
            siparis_Services.Update(siparis);

            return RedirectToAction("SiparisAnaSayfa");
        }

        public ActionResult SiparisSilme(_Siparis siparis)
        {
            siparis_Services.Delete(siparis);

            return RedirectToAction("SiparisAnaSayfa");
        }


    }

}