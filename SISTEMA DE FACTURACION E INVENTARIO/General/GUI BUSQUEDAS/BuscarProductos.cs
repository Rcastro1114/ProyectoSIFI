using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI_BUSQUEDAS
{
    public partial class BuscarProductos : Form
    {
        BindingSource _DATOS = new BindingSource();

        public static String _idProductos;
        public static String _Productos;

        private void CargarBusquedaProductos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.BUSCARPRODUCTOS();
                dgv_bProductos.AutoGenerateColumns = false;
                dgv_bProductos.DataSource = _DATOS;
                lbl_registros_prod.Text = dgv_bProductos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public BuscarProductos()
        {
            InitializeComponent();
        }

        private void BuscarProductos_Load(object sender, EventArgs e)
        {
            CargarBusquedaProductos();
        }

        private void dgv_bProductos_DoubleClick(object sender, EventArgs e)
        {
            _idProductos = dgv_bProductos.CurrentRow.Cells[0].Value.ToString();
            //_Productos = dgv_bProductos.CurrentRow.Cells[1].Value.ToString();
            Close();
        }
    }
}
