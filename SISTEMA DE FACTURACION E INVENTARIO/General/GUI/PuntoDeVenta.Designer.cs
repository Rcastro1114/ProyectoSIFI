
namespace General.GUI
{
    partial class PuntoDeVenta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.idVentas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.idVentas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 458);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(541, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 458);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° de Factura";
            // 
            // idVentas
            // 
            this.idVentas.Location = new System.Drawing.Point(411, 13);
            this.idVentas.Name = "idVentas";
            this.idVentas.ReadOnly = true;
            this.idVentas.Size = new System.Drawing.Size(100, 20);
            this.idVentas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(55, 11);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(93, 20);
            this.fecha.TabIndex = 3;
            this.fecha.Value = new System.DateTime(2023, 5, 29, 17, 57, 19, 0);
            // 
            // PuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PuntoDeVenta";
            this.Text = "PuntoDeVenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}