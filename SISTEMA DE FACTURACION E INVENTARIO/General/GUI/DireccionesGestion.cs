using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class DireccionesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.DIRECCIONES();
                dtgvDirecciones.AutoGenerateColumns = false;
                dtgvDirecciones.DataSource = _DATOS;
                lblRegistrosClt.Text = dtgvDirecciones.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public DireccionesGestion()
        {
            InitializeComponent();
        }

        private void DireccionesGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
