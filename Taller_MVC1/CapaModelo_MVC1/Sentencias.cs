using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC1
{
    public class Sentencias
    {
        Conexion con = new Conexion();
        public OdbcDataAdapter llenarTbl(string nombreTabla)
        {
            string sql = "SELECT * FROM " + nombreTabla + ";";
            OdbcDataAdapter daSentencias = new OdbcDataAdapter(sql, con.conexion());
            return daSentencias;
        }
    }
}
