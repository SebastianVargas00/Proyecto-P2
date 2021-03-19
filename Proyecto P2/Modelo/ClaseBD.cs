using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Proyecto_P2
{
    class ClaseBD
    {
        public static SqlConnection Connect()
        {
            SqlConnection conexion = new SqlConnection("server=USER-PC ; database=proyecto ; integrated security = true;");
            conexion.Open();
            return conexion;


        }   
    }
}
