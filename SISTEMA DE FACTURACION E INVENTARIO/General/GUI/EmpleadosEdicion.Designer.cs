
namespace General.GUI
{
    partial class EmpleadosEdicion
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_idEmpleados = new System.Windows.Forms.TextBox();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.txt_DUI = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_idDirecciones = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Direccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "idEmpleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DUI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "idDirecciones";
            // 
            // txt_idEmpleados
            // 
            this.txt_idEmpleados.Location = new System.Drawing.Point(129, 25);
            this.txt_idEmpleados.Name = "txt_idEmpleados";
            this.txt_idEmpleados.ReadOnly = true;
            this.txt_idEmpleados.Size = new System.Drawing.Size(69, 20);
            this.txt_idEmpleados.TabIndex = 7;
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Location = new System.Drawing.Point(129, 71);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(228, 20);
            this.txt_Nombres.TabIndex = 8;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Location = new System.Drawing.Point(129, 122);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(228, 20);
            this.txt_Apellidos.TabIndex = 9;
            // 
            // txt_DUI
            // 
            this.txt_DUI.Location = new System.Drawing.Point(129, 171);
            this.txt_DUI.Name = "txt_DUI";
            this.txt_DUI.Size = new System.Drawing.Size(100, 20);
            this.txt_DUI.TabIndex = 10;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(129, 224);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefono.TabIndex = 11;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(129, 273);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(228, 20);
            this.txt_Correo.TabIndex = 12;
            // 
            // txt_idDirecciones
            // 
            this.txt_idDirecciones.Location = new System.Drawing.Point(129, 320);
            this.txt_idDirecciones.Name = "txt_idDirecciones";
            this.txt_idDirecciones.Size = new System.Drawing.Size(228, 20);
            this.txt_idDirecciones.TabIndex = 13;
            this.txt_idDirecciones.Text = "Para generar ID ingrese la dirección";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(123, 366);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 14;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(326, 366);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 15;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Direccion
            // 
            this.btn_Direccion.Location = new System.Drawing.Point(384, 317);
            this.btn_Direccion.Name = "btn_Direccion";
            this.btn_Direccion.Size = new System.Drawing.Size(107, 23);
            this.btn_Direccion.TabIndex = 16;
            this.btn_Direccion.Text = "Agregar Dirección";
            this.btn_Direccion.UseVisualStyleBackColor = true;
            this.btn_Direccion.Click += new System.EventHandler(this.btn_Direccion_Click);
            // 
            // EmpleadosEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 406);
            this.Controls.Add(this.btn_Direccion);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_idDirecciones);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_DUI);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.txt_Nombres);
            this.Controls.Add(this.txt_idEmpleados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmpleadosEdicion";
            this.Text = "EmpleadosEdicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Direccion;
        public System.Windows.Forms.TextBox txt_idEmpleados;
        public System.Windows.Forms.TextBox txt_Nombres;
        public System.Windows.Forms.TextBox txt_Apellidos;
        public System.Windows.Forms.TextBox txt_DUI;
        public System.Windows.Forms.TextBox txt_Telefono;
        public System.Windows.Forms.TextBox txt_Correo;
        public System.Windows.Forms.TextBox txt_idDirecciones;
    }
}