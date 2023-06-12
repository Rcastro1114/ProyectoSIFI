using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIFI.GUI
{
    public partial class Main : Form
    {
        SessionManager.Session oSesion = SessionManager.Session.Instancia;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = oSesion.Usuario;
            lblRol.Text = oSesion.Rol;
        }

        private void gestionDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.RolesGestion f = new General.GUI.RolesGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception)
            {
            }
        }

        private void gestionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.ClientesGestion f = new General.GUI.ClientesGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception)
            {
            }
        }

        private void gestionDeDireccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.DireccionesGestion f = new General.GUI.DireccionesGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception)
            {
            }
        }

        private void gestiónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.ProductosGestion f = new General.GUI.ProductosGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception)
            {
            }
        }

        private void gestiónEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.EmpleadosGestion f = new General.GUI.EmpleadosGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception)
            {
            }
        }

        private void puntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.PuntoDeVenta f = new General.GUI.PuntoDeVenta();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception)
            {
            }
        }

        private void registrarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.ComprasGestion f = new General.GUI.ComprasGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception)
            {
            }
        }

        private void kardexDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI_KARDEX.Kardex f = new General.GUI_KARDEX.Kardex();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception)
            {
            }
        }

        private void gestiónProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.GUI.ProveedoresGestion f = new General.GUI.ProveedoresGestion();
                f.MdiParent = this;
                f.Show();
            }
            catch (Exception)
            {
            }
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteProductos.GUI.ViewProductos f = new ReporteProductos.GUI.ViewProductos();
            f.Show();
        }
    }
}
