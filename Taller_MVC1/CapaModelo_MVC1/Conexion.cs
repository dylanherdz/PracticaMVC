using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC1
{
    class Conexion
    {
        public OdbcConnection conexion()
        {
            OdbcConnection cn = new OdbcConnection("Dsn=asignacion_de_cursos");
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al conectar a la base de datos: ");
            }
            return cn;
        }
        public void desconexion(OdbcConnection cn)
        {
            try
            {
                cn.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al desconectar de la base de datos: ");
            }
        }
    }
}