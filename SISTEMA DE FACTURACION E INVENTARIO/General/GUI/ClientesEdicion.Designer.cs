
namespace General.GUI
{
    partial class ClientesEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesEdicion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_idCliente = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbl_DUI = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lbl_Direcciones = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 457);
            this.panel1.TabIndex = 0;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(62, 231);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(119, 66);
            this.txtCliente.TabIndex = 8;
            this.txtCliente.Text = "EDICION DE CLIENTES";
            this.txtCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_idCliente
            // 
            this.lbl_idCliente.AutoSize = true;
            this.lbl_idCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_idCliente.Location = new System.Drawing.Point(279, 14);
            this.lbl_idCliente.Name = "lbl_idCliente";
            this.lbl_idCliente.Size = new System.Drawing.Size(18, 13);
            this.lbl_idCliente.TabIndex = 1;
            this.lbl_idCliente.Text = "ID";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(281, 33);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(201, 20);
            this.txtIDCliente.TabIndex = 2;
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Nombres.Location = new System.Drawing.Point(279, 71);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(49, 13);
            this.lbl_Nombres.TabIndex = 3;
            this.lbl_Nombres.Text = "Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(282, 91);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(201, 20);
            this.txtNombres.TabIndex = 4;
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Apellidos.Location = new System.Drawing.Point(279, 129);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(49, 13);
            this.lbl_Apellidos.TabIndex = 5;
            this.lbl_Apellidos.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(281, 150);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(201, 20);
            this.txtApellidos.TabIndex = 6;
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Telefono.Location = new System.Drawing.Point(278, 247);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefono.TabIndex = 7;
            this.lbl_Telefono.Text = "Teléfono";
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(281, 211);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(201, 20);
            this.txtDUI.TabIndex = 8;
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Correo.Location = new System.Drawing.Point(278, 303);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(38, 13);
            this.lbl_Correo.TabIndex = 9;
            this.lbl_Correo.Text = "Correo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(281, 268);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(201, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // lbl_DUI
            // 
            this.lbl_DUI.AutoSize = true;
            this.lbl_DUI.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_DUI.Location = new System.Drawing.Point(279, 190);
            this.lbl_DUI.Name = "lbl_DUI";
            this.lbl_DUI.Size = new System.Drawing.Size(26, 13);
            this.lbl_DUI.TabIndex = 11;
            this.lbl_DUI.Text = "DUI";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(281, 323);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(201, 20);
            this.txtCorreo.TabIndex = 12;
            // 
            // lbl_Direcciones
            // 
            this.lbl_Direcciones.AutoSize = true;
            this.lbl_Direcciones.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Direcciones.Location = new System.Drawing.Point(281, 357);
            this.lbl_Direcciones.Name = "lbl_Direcciones";
            this.lbl_Direcciones.Size = new System.Drawing.Size(66, 13);
            this.lbl_Direcciones.TabIndex = 13;
            this.lbl_Direcciones.Text = "ID Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(281, 378);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(201, 20);
            this.txtDireccion.TabIndex = 14;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(281, 429);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 15;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(393, 429);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 16;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // ClientesEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(133)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(495, 464);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lbl_Direcciones);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lbl_DUI);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lbl_Apellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lbl_Nombres);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.lbl_idCliente);
            this.Controls.Add(this.panel1);
            this.Name = "ClientesEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtCliente;
        private System.Windows.Forms.Label lbl_idCliente;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbl_DUI;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lbl_Direcciones;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}