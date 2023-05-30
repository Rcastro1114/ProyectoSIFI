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
    public partial class ClientesEdicion : Form
    {
        public ClientesEdicion()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Clientes oClientes = new CLS.Clientes();
            //Sincronizar la entidad con la interfaz
            oClientes.Nombres = txtNombres.Text;
            oClientes.Apellidos = txtNombres.Text;
            oClientes.DUI = txtDUI.Text;
            oClientes.Telefono = txtTelefono.Text;
            oClientes.Correo = txtCorreo.Text;
            oClientes.IdDirecciones = txtDireccion.Text;
            oClientes.IdClientes = txtIDCliente.Text;
            //Identificar la accion a realizar
            if (txtIDRol.TextLength > 0)
            {
                //Realizar la operacion de actualizar
                if (oRol.Actualizar())
                {
                    MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue actualizado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //Realizar la operacion de insertar
                if (oRol.Insertar())
                {
                    MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue insertado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
    }
}
