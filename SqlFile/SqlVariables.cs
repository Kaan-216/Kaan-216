using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Proje7.SqlFile
{
    public static class SqlVariables
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E4T29GK;Initial Catalog=UserData;Integrated Security=True");

        public static void BaglantiKontrol(SqlConnection tempBağlanti)
        {
            if (tempBağlanti.State == ConnectionState.Closed)
            {
                tempBağlanti.Open();
            }
            else
            {

            }
        }

    }
}
