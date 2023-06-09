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
    }
}
