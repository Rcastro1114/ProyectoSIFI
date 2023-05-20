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
    public partial class ProductosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();


        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.PRODUCTOS();
                dtgvProductos.AutoGenerateColumns = false;
                dtgvProductos.DataSource = _DATOS;
                lblRegistrosProd.Text = dtgvProductos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public ProductosGestion()
        {
            InitializeComponent();
        }

        private void ProductosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProductosEdicion f = new ProductosEdicion();
                f.txt_idProductos.Text = dtgvProductos.CurrentRow.Cells["idProductos"].Value.ToString();
                f.txt_Productos.Text = dtgvProductos.CurrentRow.Cells["Productos"].Value.ToString();
                f.txt_PrecioUnitario.Text = dtgvProductos.CurrentRow.Cells["PrecioUnitario"].Value.ToString();
                f.txt_Marca.Text = dtgvProductos.CurrentRow.Cells["Marca"].Value.ToString();
                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Product oProductos = new CLS.Product();
                oProductos.IdProductos = dtgvProductos.CurrentRow.Cells["idProductos"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oProductos.Eliminar())
                {
                    MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue eliminado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            ProductosEdicion f = new ProductosEdicion();
            f.ShowDialog();
            CargarDatos();
        }
    }
}
