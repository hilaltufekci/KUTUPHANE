using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using KutuphaneDapperUygulamasi.Models;

namespace KutuphaneDapperUygulamasi.Controllers
{
    public class YazarController : Controller
    {
        // GET: Yazar
        public ActionResult Index()
        {
            return View(DP.ReturnList<Yazar>("YazarListele"));
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
                param.Add("@YazarNo", id);
                return View(DP.ReturnList<Yazar>("YazarSirala", param).FirstOrDefault<Yazar>());
            }
        }
        [HttpPost]
        public ActionResult EY(Yazar araclar)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@YazarNo", araclar.YazarNo);
            param.Add("@YazarAdi", araclar.YazarAdi);
            param.Add("@YazarSoyadi", araclar.YazarSoyadi);
            param.Add("@KitapSayisi", araclar.KitapSayisi);
            DP.ExReturn("YazarEY", param);
            return RedirectToAction("Index");


        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@YazarNo", id);
            DP.ExReturn("YazarSil", param);
            return RedirectToAction("Index");
        }
    }
}