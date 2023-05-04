using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KutuphaneDapperUygulamasi.Models
{
    public class Personel
    {
        public int PersonelNo { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyad { get; set; }
        public int PersonelYas { get; set; }
        public int PersonelMaas { get; set; }
    }
}