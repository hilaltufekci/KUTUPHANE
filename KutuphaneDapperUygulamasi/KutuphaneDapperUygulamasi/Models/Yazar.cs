using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KutuphaneDapperUygulamasi.Models
{
    public class Yazar
    {
        public int YazarNo { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public int KitapSayisi { get; set; }

    }
}