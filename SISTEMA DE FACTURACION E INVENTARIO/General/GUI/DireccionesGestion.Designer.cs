
namespace General.GUI
{
    partial class DireccionesGestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DireccionesGestion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRegistrosClt = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgvDirecciones = new System.Windows.Forms.DataGridView();
            this.idDirecciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Residencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cecerio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMunicipios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDirecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(545, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel2.Text = "Editar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel3.Image")));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(79, 22);
            this.toolStripLabel3.Text = "Agregar";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRegistrosClt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 310);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(545, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRegistrosClt
            // 
            this.lblRegistrosClt.Name = "lblRegistrosClt";
            this.lblRegistrosClt.Size = new System.Drawing.Size(133, 17);
            this.lblRegistrosClt.Text = "0 Registros Encontrados";
            // 
            // dtgvDirecciones
            // 
            this.dtgvDirecciones.AllowUserToAddRows = false;
            this.dtgvDirecciones.AllowUserToDeleteRows = false;
            this.dtgvDirecciones.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDirecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDirecciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDirecciones,
            this.Residencia,
            this.Canton,
            this.Cecerio,
            this.idMunicipios});
            this.dtgvDirecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDirecciones.Location = new System.Drawing.Point(0, 25);
            this.dtgvDirecciones.Name = "dtgvDirecciones";
            this.dtgvDirecciones.ReadOnly = true;
            this.dtgvDirecciones.Size = new System.Drawing.Size(545, 285);
            this.dtgvDirecciones.TabIndex = 3;
            // 
            // idDirecciones
            // 
            this.idDirecciones.DataPropertyName = "idDirecciones";
            this.idDirecciones.HeaderText = "idDirecciones";
            this.idDirecciones.Name = "idDirecciones";
            this.idDirecciones.ReadOnly = true;
            // 
            // Residencia
            // 
            this.Residencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Residencia.DataPropertyName = "Residencia";
            this.Residencia.HeaderText = "Residencia";
            this.Residencia.Name = "Residencia";
            this.Residencia.ReadOnly = true;
            // 
            // Canton
            // 
            this.Canton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Canton.DataPropertyName = "Canton";
            this.Canton.HeaderText = "Canton";
            this.Canton.Name = "Canton";
            this.Canton.ReadOnly = true;
            // 
            // Cecerio
            // 
            this.Cecerio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cecerio.DataPropertyName = "Cacerio";
            this.Cecerio.HeaderText = "Cacerio";
            this.Cecerio.Name = "Cecerio";
            this.Cecerio.ReadOnly = true;
            // 
            // idMunicipios
            // 
            this.idMunicipios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idMunicipios.DataPropertyName = "idMunicipios";
            this.idMunicipios.HeaderText = "idMunicipio";
            this.idMunicipios.Name = "idMunicipios";
            this.idMunicipios.ReadOnly = true;
            // 
            // DireccionesGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 332);
            this.Controls.Add(this.dtgvDirecciones);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DireccionesGestion";
            this.Text = "DireccionesGestion";
            this.Load += new System.EventHandler(this.DireccionesGestion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDirecciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dtgvDirecciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistrosClt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDirecciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Residencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cecerio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMunicipios;
    }
}