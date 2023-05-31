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
    public partial class PuntoDeVenta : Form
    {

        public PuntoDeVenta()
        {
            InitializeComponent();
        }

        private void PuntoDeVenta_Load(object sender, EventArgs e)
        {
            txt_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_idproductos.Text = "0";
            txt_paga.Text = "";
            txt_cambio.Text = "";
            txt_Total.Text = "";
        }

        private void btn_buscar_emp_Click(object sender, EventArgs e)
        {
            using (var formulario = new EmpleadosGestion())
            {
                var result = formulario.ShowDialog();

                if(result == DialogResult.OK)
                {
                    txt_idEmpleados.Text = formulario._Empleados.idEmpleados.ToString();
                    txt_Nombres_emp.Text = formulario._Empleados.Nombres.ToString();
                    txt_apellidos_emp.Text = formulario._Empleados.Apellidos.ToString();
                }
                else
                {
                    txt_idEmpleados.Select();
                }
            }
        }

        private void btn_Buscar_Prod_Click(object sender, EventArgs e)
        {
            using (var formulario = new ProductosGestion())
            {
                var result = formulario.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_idproductos.Text = formulario._Productos.idProductos.ToString();
                    txt_producto.Text = formulario._Productos.Productos.ToString();
                    txt_precio_pro.Text = formulario._Productos.PrecioUnitario.ToString("0.00");
                    txt_Cantidad.Select();
                }
                else
                {
                    txt_idproductos.Select();
                }

            }
        }
    }
}
