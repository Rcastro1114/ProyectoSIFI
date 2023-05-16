
namespace General.GUI
{
    partial class RolesEdicion
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
            this.lbl_idRol = new System.Windows.Forms.Label();
            this.txtIDRol = new System.Windows.Forms.TextBox();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_idRol
            // 
            this.lbl_idRol.AutoSize = true;
            this.lbl_idRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idRol.ForeColor = System.Drawing.Color.White;
            this.lbl_idRol.Location = new System.Drawing.Point(14, 22);
            this.lbl_idRol.Name = "lbl_idRol";
            this.lbl_idRol.Size = new System.Drawing.Size(47, 16);
            this.lbl_idRol.TabIndex = 0;
            this.lbl_idRol.Text = "IDRol";
            // 
            // txtIDRol
            // 
            this.txtIDRol.Location = new System.Drawing.Point(15, 44);
            this.txtIDRol.Name = "txtIDRol";
            this.txtIDRol.ReadOnly = true;
            this.txtIDRol.Size = new System.Drawing.Size(112, 20);
            this.txtIDRol.TabIndex = 1;
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rol.ForeColor = System.Drawing.Color.White;
            this.lbl_Rol.Location = new System.Drawing.Point(12, 127);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(32, 16);
            this.lbl_Rol.TabIndex = 2;
            this.lbl_Rol.Text = "Rol";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(15, 146);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(172, 20);
            this.txtRol.TabIndex = 3;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(103, 192);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(274, 192);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // RolesEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(461, 239);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.lbl_Rol);
            this.Controls.Add(this.txtIDRol);
            this.Controls.Add(this.lbl_idRol);
            this.Name = "RolesEdicion";
            this.Text = "RolesEdicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_idRol;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.TextBox txtIDRol;
        public System.Windows.Forms.TextBox txtRol;
    }
}