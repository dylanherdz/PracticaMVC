using System.Data;
using System.Data.Odbc;

namespace CapaControlador_MVC1
{
    public class Controlador
    {
        // Cadena de conexión: elige la que corresponda a tu base de datos
        private string ConnectionString = "DSN=asignacion_de_cursos"; // o la cadena directa

        public DataTable llenarDgv(string nombreTabla)
        {
            // Construir consulta dinámica con el nombre de la tabla
            string consulta = "SELECT * FROM " + nombreTabla;

            // Crear adaptador y DataTable
            OdbcDataAdapter adaptador = new OdbcDataAdapter(consulta, ConnectionString);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt;
        }
    }
}