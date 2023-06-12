
namespace General.GUI_BUSQUEDAS
{
    partial class BuscarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarProductos));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_registros_prod = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv_bProductos = new System.Windows.Forms.DataGridView();
            this.idProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_registros_prod});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(477, 22);
            this.statusStrip1.TabIndex = 3;
            // 
            // lbl_registros_prod
            // 
            this.lbl_registros_prod.Name = "lbl_registros_prod";
            this.lbl_registros_prod.Size = new System.Drawing.Size(133, 17);
            this.lbl_registros_prod.Text = "0 Registros encontrados";
            // 
            // dgv_bProductos
            // 
            this.dgv_bProductos.AllowUserToAddRows = false;
            this.dgv_bProductos.AllowUserToDeleteRows = false;
            this.dgv_bProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductos,
            this.Productos,
            this.PrecioUnitario,
            this.Stock});
            this.dgv_bProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bProductos.Location = new System.Drawing.Point(0, 0);
            this.dgv_bProductos.Name = "dgv_bProductos";
            this.dgv_bProductos.ReadOnly = true;
            this.dgv_bProductos.RowHeadersVisible = false;
            this.dgv_bProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bProductos.Size = new System.Drawing.Size(477, 428);
            this.dgv_bProductos.TabIndex = 5;
            this.dgv_bProductos.DoubleClick += new System.EventHandler(this.dgv_bProductos_DoubleClick);
            // 
            // idProductos
            // 
            this.idProductos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProductos.DataPropertyName = "idProductos";
            this.idProductos.HeaderText = "idProductos";
            this.idProductos.Name = "idProductos";
            this.idProductos.ReadOnly = true;
            // 
            // Productos
            // 
            this.Productos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Productos.DataPropertyName = "Productos";
            this.Productos.HeaderText = "Productos";
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.PrecioUnitario.HeaderText = "PrecioUnitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // BuscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.dgv_bProductos);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarProductos";
            this.Text = "BuscarProductos";
            this.Load += new System.EventHandler(this.BuscarProductos_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_registros_prod;
        private System.Windows.Forms.DataGridView dgv_bProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}