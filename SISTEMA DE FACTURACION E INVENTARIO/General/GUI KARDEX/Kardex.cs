using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI_KARDEX
{
    public partial class Kardex : Form
    {
        BindingSource _DATOS = new BindingSource();
        DataTable oKardexProductos = new DataTable();

        private void CargarBusqueda()
        {
            try 
            {
                _DATOS.DataSource = DataManager.DBConsultas.BUSCARPRDUCTOKARDEX(txt_idProducto.Text.ToString());
                dgt_kardex.AutoGenerateColumns = false;
                dgt_kardex.DataSource = _DATOS;
            }
            catch(Exception)
            {

            }
        }

        private void CargarKardex()
        {
            try
            {
                oKardexProductos = DataManager.DBConsultas.KARDEXPRODUCTOS();
                dgt_kardex.DataSource = oKardexProductos;
                lblKardex.Text = dgt_kardex.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public Kardex()
        {
            InitializeComponent();
        }

        private void Kardex_Load(object sender, EventArgs e)
        {
            CargarKardex();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if(txt_idProducto.Text.Length > 0)
            {
                CargarBusqueda();
            }
            else
            {
                MessageBox.Show("No se ha encontrado el producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
