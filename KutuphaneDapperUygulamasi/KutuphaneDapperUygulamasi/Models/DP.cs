using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace KutuphaneDapperUygulamasi.Models
{
    public static class DP
    {
        private static string connectionString = "Data Source =DESKTOP-K4EVO3J; Initial Catalog=Kütüphane; Integrated Security =true";
        public static void ExReturn(string procadi, DynamicParameters param = null)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                baglanti.Execute(procadi, param, commandType: CommandType.StoredProcedure);
            }
        }
        public static IEnumerable<T> ReturnList<T>(string procadi, DynamicParameters param = null)
        {

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                return baglanti.Query<T>(procadi, param, commandType: CommandType.StoredProcedure);

            }
        }
    }
}