using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneRandevuSistemi
{
    internal class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan=new SqlConnection("Data Source=DESKTOP-5AD7K8R;Initial Catalog=HastaneSistem;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
