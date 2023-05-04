using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KutuphaneDapperUygulamasi.Models
{
    public  class Kitap
    {
        public int KitapNo { get; set; }
        public string KitapAdi { get; set; }
        public string Tür { get; set; }
        public string Yayinevi { get; set; }
        public int SayfaSayisi { get; set; }

    }
}