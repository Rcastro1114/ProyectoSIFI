
namespace General.GUI
{
    partial class EmpleadosGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadosGestion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Editar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Eliminar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Agregar = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRegistrosEmpleados = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgvEmpleados = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Eliminar,
            this.toolStripSeparator2,
            this.btn_Editar,
            this.toolStripSeparator1,
            this.btn_Agregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1014, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Editar
            // 
            this.btn_Editar.AutoSize = false;
            this.btn_Editar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.White;
            this.btn_Editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Editar.Image")));
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(100, 22);
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.AutoSize = false;
            this.btn_Eliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(100, 22);
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.AutoSize = false;
            this.btn_Agregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(100, 22);
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRegistrosEmpleados});
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1014, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRegistrosEmpleados
            // 
            this.lblRegistrosEmpleados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosEmpleados.ForeColor = System.Drawing.Color.White;
            this.lblRegistrosEmpleados.Name = "lblRegistrosEmpleados";
            this.lblRegistrosEmpleados.Size = new System.Drawing.Size(168, 20);
            this.lblRegistrosEmpleados.Text = "0 Registros Encontrados";
            // 
            // dtgvEmpleados
            // 
            this.dtgvEmpleados.AllowUserToAddRows = false;
            this.dtgvEmpleados.AllowUserToDeleteRows = false;
            this.dtgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvEmpleados.Location = new System.Drawing.Point(0, 25);
            this.dtgvEmpleados.Name = "dtgvEmpleados";
            this.dtgvEmpleados.ReadOnly = true;
            this.dtgvEmpleados.Size = new System.Drawing.Size(1014, 365);
            this.dtgvEmpleados.TabIndex = 2;
            // 
            // EmpleadosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 415);
            this.Controls.Add(this.dtgvEmpleados);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EmpleadosGestion";
            this.Text = "EmpleadosGestion";
            this.Load += new System.EventHandler(this.EmpleadosGestion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dtgvEmpleados;
        private System.Windows.Forms.ToolStripLabel btn_Editar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel btn_Eliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel btn_Agregar;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistrosEmpleados;
    }
}