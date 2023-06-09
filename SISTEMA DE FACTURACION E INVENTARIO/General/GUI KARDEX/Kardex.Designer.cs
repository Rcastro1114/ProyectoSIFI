
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgt_kardex = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblKardex = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_kardex)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kardex de productos";
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
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblKardex});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(628, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblKardex
            // 
            this.lblKardex.Name = "lblKardex";
            this.lblKardex.Size = new System.Drawing.Size(133, 17);
            this.lblKardex.Text = "0 Registros encontrados";
            // 
            // Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
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
    }
}