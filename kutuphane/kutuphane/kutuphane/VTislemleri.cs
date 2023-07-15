using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OleDb;

namespace kutuphane
{
    class VTislemleri
    {
        string baglantiyolu = ConfigurationManager.ConnectionStrings["VTbaglantiadresi"].ConnectionString;

        public OleDbConnection Baglan()
        {
            OleDbConnection baglanti = new OleDbConnection(baglantiyolu);
            OleDbConnection.ReleaseObjectPool();

            return baglanti;
        }
    
    
    }
}
