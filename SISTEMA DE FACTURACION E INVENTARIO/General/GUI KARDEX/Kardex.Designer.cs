
namespace General.GUI_KARDEX
{
    partial class Kardex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kardex));
            this.label1 = new System.Windows.Forms.Label();
            this.dgt_kardex = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblKardex = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idProducto = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_kardex)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kardex de productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgt_kardex
            // 
            this.dgt_kardex.AllowUserToAddRows = false;
            this.dgt_kardex.AllowUserToDeleteRows = false;
            this.dgt_kardex.BackgroundColor = System.Drawing.Color.White;
            this.dgt_kardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_kardex.Location = new System.Drawing.Point(12, 62);
            this.dgt_kardex.Name = "dgt_kardex";
            this.dgt_kardex.ReadOnly = true;
            this.dgt_kardex.RowHeadersVisible = false;
            this.dgt_kardex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgt_kardex.Size = new System.Drawing.Size(604, 363);
            this.dgt_kardex.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblKardex});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblKardex
            // 
            this.lblKardex.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblKardex.ForeColor = System.Drawing.Color.White;
            this.lblKardex.Name = "lblKardex";
            this.lblKardex.Size = new System.Drawing.Size(168, 20);
            this.lblKardex.Text = "0 Registros encontrados";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(639, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 56);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar producto por ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_idProducto
            // 
            this.txt_idProducto.Location = new System.Drawing.Point(671, 242);
            this.txt_idProducto.Name = "txt_idProducto";
            this.txt_idProducto.Size = new System.Drawing.Size(145, 20);
            this.txt_idProducto.TabIndex = 4;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(705, 268);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_idProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgt_kardex);
            this.Controls.Add(this.label1);
            this.Name = "Kardex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kardex";
            this.Load += new System.EventHandler(this.Kardex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgt_kardex)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgt_kardex;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblKardex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idProducto;
        private System.Windows.Forms.Button btn_buscar;
    }
}