using CapaControlador_MVC1;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaVista_MVC1
{
    public partial class frmPrincipal : Form
    {
        string nombreTabla = "edificio";
        Controlador controlador = new Controlador();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void actualizarDataGridView()
        {
            DataTable dtVista = controlador.llenarDgv(nombreTabla);
            dgvConsultaTabla.DataSource = dtVista;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            actualizarDataGridView();
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            actualizarDataGridView();
        }

    }
}