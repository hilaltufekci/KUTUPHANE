using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using KutuphaneDapperUygulamasi.Models;


namespace KutuphaneDapperUygulamasi.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        public ActionResult Index()
        {
            return View(DP.ReturnList<Personel>("PersonelListele"));
        }
        public ActionResult EY(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@PersonelNo", id);
                return View(DP.ReturnList<Personel>("PersonelSirala", param).FirstOrDefault<Personel>());
            }
        }
        [HttpPost]
        public ActionResult EY(Personel araclar)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@PersonelNo", araclar.PersonelNo);
            param.Add("@PersonelAdi", araclar.PersonelAdi);
            param.Add("@PersonelSoyad", araclar.PersonelSoyad);
            param.Add("@PersonelYas", araclar.PersonelYas);
            param.Add("@PersonelMaas", araclar.PersonelMaas);
            DP.ExReturn("PersonelEY", param);
            return RedirectToAction("Index");


        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@PersonelNo", id);
            DP.ExReturn("PersonelSil", param);
            return RedirectToAction("Index");
        }
    }
}