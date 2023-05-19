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
    public partial class DireccionesEdicion : Form
    {

        private void CargarMunicipios()
        {
            DataTable oMunicipios = new DataTable();
            try
            {
                oMunicipios = DataManager.DBConsultas.MUNICIPIOS();
                cbboMunicipios.DataSource = oMunicipios;
                cbboMunicipios.DisplayMember = "municipios";
                cbboMunicipios.ValueMember = "idMunicipios";
            }
            catch (Exception)
            {

            }
        }

        public DireccionesEdicion()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            CLS.Direcciones oDirecciones = new CLS.Direcciones();
            oDirecciones.Residencia = txt_Residencia.Text;
            oDirecciones.Canton = txt_Canton.Text;
            oDirecciones.Cacerio = txt_Cacerio.Text;
            oDirecciones.IdMunicipios = int.Parse(cbboMunicipios.SelectedValue.ToString());
            oDirecciones.IdDirecciones = txt_idDirecciones.Text;

            if(txt_idDirecciones.TextLength > 0)
            {
                if (oDirecciones.Actualizar())
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
                if (oDirecciones.Insertar())
                {
                    MessageBox.Show("¡Registro agregado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue agregado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DireccionesEdicion_Load(object sender, EventArgs e)
        {
            CargarMunicipios();
        }
    }
}
