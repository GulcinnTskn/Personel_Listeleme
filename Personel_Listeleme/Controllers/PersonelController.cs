using Newtonsoft.Json;
using Personel_Listeleme.Models;
using Personel_Listeleme.MyModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personel_Listeleme.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        MVCEntities1 db = new MVCEntities1();

        [HttpGet]
        public ActionResult Index()
        {

            return View();

            //var deger = db.TBL_PERSONEL.ToList();


            //return View(deger);
        }


        public JsonResult GetPersonelList()
        {
            List<PERSONELLER> liste = db.TBL_PERSONEL.Select(x => new PERSONELLER
            {
                ID = x.ID,
                Title = x.Title,
                First_Name = x.First_Name,
                Last_Name = x.Last_Name,
                Position = x.Position,
                Birth_Date = x.Birth_Date,
                Hire_Date = x.Hire_Date,
                Notes = x.Notes,
                Address = x.Address,
                State = x.State,

            }).ToList();
            return Json(liste, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]

        public ActionResult Guncelle(TBL_PERSONEL p)
        {
            try
            {
                TBL_PERSONEL tBL_PERSONEL = new TBL_PERSONEL();
                tBL_PERSONEL = db.TBL_PERSONEL.Where(s => s.ID == p.ID).FirstOrDefault();
                if (tBL_PERSONEL != null)
                {
                    tBL_PERSONEL.Address = p.Address;
                    tBL_PERSONEL.Last_Name = p.Last_Name;
                    tBL_PERSONEL.First_Name = p.First_Name;
                    tBL_PERSONEL.Notes = p.Notes;
                    tBL_PERSONEL.Title = p.Title;
                    tBL_PERSONEL.State = p.State;
                    tBL_PERSONEL.Birth_Date = p.Birth_Date;
                    tBL_PERSONEL.Hire_Date = p.Hire_Date;
                    tBL_PERSONEL.Position = p.Position;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                ;
            }


            return RedirectToAction("Index");
        }

        public JsonResult GetEditPersonel(int ID)
        {
            var model = db.TBL_PERSONEL.FirstOrDefault(x => x.ID == ID);
            string value = "";
            value = JsonConvert.SerializeObject(model, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            });

            return Json(value, JsonRequestBehavior.AllowGet);
        }

    }
}