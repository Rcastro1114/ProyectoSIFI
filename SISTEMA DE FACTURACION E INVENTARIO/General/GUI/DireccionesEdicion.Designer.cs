
namespace General.GUI
{
    partial class DireccionesEdicion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_idDirecciones = new System.Windows.Forms.TextBox();
            this.txt_Residencia = new System.Windows.Forms.TextBox();
            this.txt_Canton = new System.Windows.Forms.TextBox();
            this.txt_Cacerio = new System.Windows.Forms.TextBox();
            this.cbboMunicipios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "idDirecciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Residencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantón";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cacerio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "idMunicipios";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(18, 344);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 5;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(294, 344);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_idDirecciones
            // 
            this.txt_idDirecciones.Location = new System.Drawing.Point(99, 32);
            this.txt_idDirecciones.Name = "txt_idDirecciones";
            this.txt_idDirecciones.Size = new System.Drawing.Size(100, 20);
            this.txt_idDirecciones.TabIndex = 7;
            // 
            // txt_Residencia
            // 
            this.txt_Residencia.Location = new System.Drawing.Point(99, 80);
            this.txt_Residencia.Name = "txt_Residencia";
            this.txt_Residencia.Size = new System.Drawing.Size(270, 20);
            this.txt_Residencia.TabIndex = 8;
            // 
            // txt_Canton
            // 
            this.txt_Canton.Location = new System.Drawing.Point(99, 139);
            this.txt_Canton.Name = "txt_Canton";
            this.txt_Canton.Size = new System.Drawing.Size(270, 20);
            this.txt_Canton.TabIndex = 9;
            // 
            // txt_Cacerio
            // 
            this.txt_Cacerio.Location = new System.Drawing.Point(99, 201);
            this.txt_Cacerio.Name = "txt_Cacerio";
            this.txt_Cacerio.Size = new System.Drawing.Size(270, 20);
            this.txt_Cacerio.TabIndex = 10;
            // 
            // cbboMunicipios
            // 
            this.cbboMunicipios.FormattingEnabled = true;
            this.cbboMunicipios.Location = new System.Drawing.Point(99, 263);
            this.cbboMunicipios.Name = "cbboMunicipios";
            this.cbboMunicipios.Size = new System.Drawing.Size(270, 21);
            this.cbboMunicipios.TabIndex = 11;
            // 
            // DireccionesEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 379);
            this.Controls.Add(this.cbboMunicipios);
            this.Controls.Add(this.txt_Cacerio);
            this.Controls.Add(this.txt_Canton);
            this.Controls.Add(this.txt_Residencia);
            this.Controls.Add(this.txt_idDirecciones);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DireccionesEdicion";
            this.Text = "DireccionesEdicion";
            this.Load += new System.EventHandler(this.DireccionesEdicion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txt_idDirecciones;
        private System.Windows.Forms.TextBox txt_Residencia;
        private System.Windows.Forms.TextBox txt_Canton;
        private System.Windows.Forms.TextBox txt_Cacerio;
        private System.Windows.Forms.ComboBox cbboMunicipios;
    }
}