
namespace TP_Programacion_3
{
    partial class Log
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.caja_nombre = new System.Windows.Forms.TextBox();
            this.caja_contrasena = new System.Windows.Forms.TextBox();
            this.etiqueta_nombre = new System.Windows.Forms.Label();
            this.etiqueta_sucursal = new System.Windows.Forms.Label();
            this.etiqueta_contrasena = new System.Windows.Forms.Label();
            this.c_caja_sucursal = new System.Windows.Forms.ComboBox();
            this.boton_entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caja_nombre
            // 
            this.caja_nombre.Location = new System.Drawing.Point(79, 34);
            this.caja_nombre.Name = "caja_nombre";
            this.caja_nombre.Size = new System.Drawing.Size(100, 20);
            this.caja_nombre.TabIndex = 0;
            this.caja_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.caja_nombre_KeyPress);
            // 
            // caja_contrasena
            // 
            this.caja_contrasena.Location = new System.Drawing.Point(79, 74);
            this.caja_contrasena.Name = "caja_contrasena";
            this.caja_contrasena.Size = new System.Drawing.Size(100, 20);
            this.caja_contrasena.TabIndex = 1;
            this.caja_contrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.caja_contrasena_KeyPress);
            // 
            // etiqueta_nombre
            // 
            this.etiqueta_nombre.AutoSize = true;
            this.etiqueta_nombre.Location = new System.Drawing.Point(12, 34);
            this.etiqueta_nombre.Name = "etiqueta_nombre";
            this.etiqueta_nombre.Size = new System.Drawing.Size(44, 13);
            this.etiqueta_nombre.TabIndex = 2;
            this.etiqueta_nombre.Text = "Nombre";
            // 
            // etiqueta_sucursal
            // 
            this.etiqueta_sucursal.AutoSize = true;
            this.etiqueta_sucursal.Location = new System.Drawing.Point(12, 115);
            this.etiqueta_sucursal.Name = "etiqueta_sucursal";
            this.etiqueta_sucursal.Size = new System.Drawing.Size(48, 13);
            this.etiqueta_sucursal.TabIndex = 3;
            this.etiqueta_sucursal.Text = "Sucursal";
            // 
            // etiqueta_contrasena
            // 
            this.etiqueta_contrasena.AutoSize = true;
            this.etiqueta_contrasena.Location = new System.Drawing.Point(12, 74);
            this.etiqueta_contrasena.Name = "etiqueta_contrasena";
            this.etiqueta_contrasena.Size = new System.Drawing.Size(61, 13);
            this.etiqueta_contrasena.TabIndex = 4;
            this.etiqueta_contrasena.Text = "Contraseña";
            // 
            // c_caja_sucursal
            // 
            this.c_caja_sucursal.FormattingEnabled = true;
            this.c_caja_sucursal.Location = new System.Drawing.Point(79, 115);
            this.c_caja_sucursal.Name = "c_caja_sucursal";
            this.c_caja_sucursal.Size = new System.Drawing.Size(121, 21);
            this.c_caja_sucursal.TabIndex = 5;
            this.c_caja_sucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.c_caja_sucursal_KeyPress);
            // 
            // boton_entrar
            // 
            this.boton_entrar.Location = new System.Drawing.Point(272, 115);
            this.boton_entrar.Name = "boton_entrar";
            this.boton_entrar.Size = new System.Drawing.Size(75, 23);
            this.boton_entrar.TabIndex = 6;
            this.boton_entrar.Text = "Entrar";
            this.boton_entrar.UseVisualStyleBackColor = true;
            this.boton_entrar.Click += new System.EventHandler(this.boton_entrar_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 178);
            this.Controls.Add(this.boton_entrar);
            this.Controls.Add(this.c_caja_sucursal);
            this.Controls.Add(this.etiqueta_contrasena);
            this.Controls.Add(this.etiqueta_sucursal);
            this.Controls.Add(this.etiqueta_nombre);
            this.Controls.Add(this.caja_contrasena);
            this.Controls.Add(this.caja_nombre);
            this.Name = "Log";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caja_nombre;
        private System.Windows.Forms.TextBox caja_contrasena;
        private System.Windows.Forms.Label etiqueta_nombre;
        private System.Windows.Forms.Label etiqueta_sucursal;
        private System.Windows.Forms.Label etiqueta_contrasena;
        private System.Windows.Forms.ComboBox c_caja_sucursal;
        private System.Windows.Forms.Button boton_entrar;
    }
}

