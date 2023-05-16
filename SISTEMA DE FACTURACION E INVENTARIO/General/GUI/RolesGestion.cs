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
    public partial class RolesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.ROLES();
                dtgvDatos.AutoGenerateColumns = false;
                dtgvDatos.DataSource = _DATOS;
                lblRegistroEmpleados.Text = dtgvDatos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public RolesGestion()
        {
            InitializeComponent();
        }

        private void RolesGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
