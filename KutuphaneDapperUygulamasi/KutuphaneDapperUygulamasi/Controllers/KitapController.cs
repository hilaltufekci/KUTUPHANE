using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using KutuphaneDapperUygulamasi.Models;

namespace KutuphaneDapperUygulamasi.Controllers
{
    public class KitapController : Controller
    {
        // GET: Kitap
        public ActionResult Index()
        {
            return View(DP.ReturnList<Kitap>("KitapListele"));
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
                param.Add("@KitapNo", id);
                return View(DP.ReturnList<Kitap>("KitapSirala", param).FirstOrDefault<Kitap>());
            }
        }
        [HttpPost]
        public ActionResult EY(Kitap araclar)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@KitapNo", araclar.KitapNo);
            param.Add("@KitapAdi", araclar.KitapAdi);
            param.Add("@Tür", araclar.Tür);
            param.Add("@Yayinevi", araclar.Yayinevi);
            param.Add("@SayfaSayisi", araclar.SayfaSayisi);
            DP.ExReturn("KitapEY", param);
            return RedirectToAction("Index");


        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@KitapNo", id);
            DP.ExReturn("KitapSil", param);
            return RedirectToAction("Index");
        }
    }
}