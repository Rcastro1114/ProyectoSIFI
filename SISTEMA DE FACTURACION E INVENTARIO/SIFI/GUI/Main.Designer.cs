﻿
namespace SIFI.GUI
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeDireccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.reporteDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.kardexToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 39);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.AutoSize = false;
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeRolesToolStripMenuItem,
            this.gestionDeClientesToolStripMenuItem,
            this.gestionDeDireccionesToolStripMenuItem,
            this.gestiónDeProductosToolStripMenuItem,
            this.gestiónEmpleadosToolStripMenuItem,
            this.gestiónProveedoresToolStripMenuItem});
            this.generalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.85F, System.Drawing.FontStyle.Bold);
            this.generalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.generalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generalToolStripMenuItem.Image")));
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // gestionDeRolesToolStripMenuItem
            // 
            this.gestionDeRolesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gestionDeRolesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestionDeRolesToolStripMenuItem.Name = "gestionDeRolesToolStripMenuItem";
            this.gestionDeRolesToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.gestionDeRolesToolStripMenuItem.Text = "Gestión de Roles";
            this.gestionDeRolesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeRolesToolStripMenuItem_Click);
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gestionDeClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestión de Clientes";
            this.gestionDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeClientesToolStripMenuItem_Click);
            // 
            // gestionDeDireccionesToolStripMenuItem
            // 
            this.gestionDeDireccionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gestionDeDireccionesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestionDeDireccionesToolStripMenuItem.Name = "gestionDeDireccionesToolStripMenuItem";
            this.gestionDeDireccionesToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.gestionDeDireccionesToolStripMenuItem.Text = "Gestión de Direcciones";
            this.gestionDeDireccionesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeDireccionesToolStripMenuItem_Click);
            // 
            // gestiónDeProductosToolStripMenuItem
            // 
            this.gestiónDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gestiónDeProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestiónDeProductosToolStripMenuItem.Name = "gestiónDeProductosToolStripMenuItem";
            this.gestiónDeProductosToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.gestiónDeProductosToolStripMenuItem.Text = "Gestión de Productos";
            this.gestiónDeProductosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeProductosToolStripMenuItem_Click);
            // 
            // gestiónEmpleadosToolStripMenuItem
            // 
            this.gestiónEmpleadosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gestiónEmpleadosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestiónEmpleadosToolStripMenuItem.Name = "gestiónEmpleadosToolStripMenuItem";
            this.gestiónEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.gestiónEmpleadosToolStripMenuItem.Text = "Gestión Empleados";
            this.gestiónEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.gestiónEmpleadosToolStripMenuItem_Click);
            // 
            // gestiónProveedoresToolStripMenuItem
            // 
            this.gestiónProveedoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gestiónProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gestiónProveedoresToolStripMenuItem.Name = "gestiónProveedoresToolStripMenuItem";
            this.gestiónProveedoresToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.gestiónProveedoresToolStripMenuItem.Text = "Gestión Proveedores";
            this.gestiónProveedoresToolStripMenuItem.Click += new System.EventHandler(this.gestiónProveedoresToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.AutoSize = false;
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntoDeVentaToolStripMenuItem});
            this.ventasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.85F, System.Drawing.FontStyle.Bold);
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ventasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasToolStripMenuItem.Image")));
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // puntoDeVentaToolStripMenuItem
            // 
            this.puntoDeVentaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.puntoDeVentaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.puntoDeVentaToolStripMenuItem.Name = "puntoDeVentaToolStripMenuItem";
            this.puntoDeVentaToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.puntoDeVentaToolStripMenuItem.Text = "Punto de Ventas";
            this.puntoDeVentaToolStripMenuItem.Click += new System.EventHandler(this.puntoDeVentaToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.AutoSize = false;
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarComprasToolStripMenuItem});
            this.comprasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.85F, System.Drawing.FontStyle.Bold);
            this.comprasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.comprasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("comprasToolStripMenuItem.Image")));
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // registrarComprasToolStripMenuItem
            // 
            this.registrarComprasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.registrarComprasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registrarComprasToolStripMenuItem.Name = "registrarComprasToolStripMenuItem";
            this.registrarComprasToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.registrarComprasToolStripMenuItem.Text = "Registrar Compras";
            this.registrarComprasToolStripMenuItem.Click += new System.EventHandler(this.registrarComprasToolStripMenuItem_Click);
            // 
            // kardexToolStripMenuItem
            // 
            this.kardexToolStripMenuItem.AutoSize = false;
            this.kardexToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kardexDeProductosToolStripMenuItem,
            this.reporteDeProductosToolStripMenuItem});
            this.kardexToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.85F, System.Drawing.FontStyle.Bold);
            this.kardexToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kardexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kardexToolStripMenuItem.Image")));
            this.kardexToolStripMenuItem.Name = "kardexToolStripMenuItem";
            this.kardexToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.kardexToolStripMenuItem.Text = "Kardex";
            // 
            // kardexDeProductosToolStripMenuItem
            // 
            this.kardexDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kardexDeProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kardexDeProductosToolStripMenuItem.Name = "kardexDeProductosToolStripMenuItem";
            this.kardexDeProductosToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.kardexDeProductosToolStripMenuItem.Text = "Kardex de Productos";
            this.kardexDeProductosToolStripMenuItem.Click += new System.EventHandler(this.kardexDeProductosToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 39);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(632, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblRol});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuario.Image")));
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(93, 21);
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblRol
            // 
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Image = ((System.Drawing.Image)(resources.GetObject("lblRol.Image")));
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(56, 21);
            this.lblRol.Text = "ROL";
            // 
            // reporteDeProductosToolStripMenuItem
            // 
            this.reporteDeProductosToolStripMenuItem.Name = "reporteDeProductosToolStripMenuItem";
            this.reporteDeProductosToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.reporteDeProductosToolStripMenuItem.Text = "Reporte de Productos";
            this.reporteDeProductosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeProductosToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
        private System.Windows.Forms.ToolStripMenuItem gestionDeRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeDireccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kardexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kardexDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProductosToolStripMenuItem;
    }
}



