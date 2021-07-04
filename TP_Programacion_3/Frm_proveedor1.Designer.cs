
namespace TP_Programacion_3
{
    partial class Frm_proveedor1
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
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.caja_direccion = new System.Windows.Forms.TextBox();
            this.etiqueta_direccion = new System.Windows.Forms.Label();
            this.caja_nombre = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.caja_telefonos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_tipo_proveedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.caja_id_proveedor = new System.Windows.Forms.TextBox();
            this.caja_dni = new System.Windows.Forms.TextBox();
            this.etiqueta_dni = new System.Windows.Forms.Label();
            this.caja_cuit = new System.Windows.Forms.TextBox();
            this.etiqueta_cuit = new System.Windows.Forms.Label();
            this.etiqueta_nro_ibb = new System.Windows.Forms.Label();
            this.caja_nro_ibb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Location = new System.Drawing.Point(281, 78);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(75, 23);
            this.boton_eliminar.TabIndex = 11;
            this.boton_eliminar.Text = "Eliminar";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            // 
            // boton_agregar
            // 
            this.boton_agregar.Location = new System.Drawing.Point(281, 35);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(75, 23);
            this.boton_agregar.TabIndex = 10;
            this.boton_agregar.Text = "Agregar";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // caja_direccion
            // 
            this.caja_direccion.Location = new System.Drawing.Point(103, 76);
            this.caja_direccion.Name = "caja_direccion";
            this.caja_direccion.Size = new System.Drawing.Size(100, 20);
            this.caja_direccion.TabIndex = 9;
            // 
            // etiqueta_direccion
            // 
            this.etiqueta_direccion.AutoSize = true;
            this.etiqueta_direccion.Location = new System.Drawing.Point(31, 76);
            this.etiqueta_direccion.Name = "etiqueta_direccion";
            this.etiqueta_direccion.Size = new System.Drawing.Size(52, 13);
            this.etiqueta_direccion.TabIndex = 8;
            this.etiqueta_direccion.Text = "Direccion";
            // 
            // caja_nombre
            // 
            this.caja_nombre.Location = new System.Drawing.Point(103, 50);
            this.caja_nombre.Name = "caja_nombre";
            this.caja_nombre.Size = new System.Drawing.Size(100, 20);
            this.caja_nombre.TabIndex = 7;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(31, 50);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(44, 13);
            this.lab.TabIndex = 6;
            this.lab.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Telefono/s";
            // 
            // caja_telefonos
            // 
            this.caja_telefonos.Location = new System.Drawing.Point(103, 102);
            this.caja_telefonos.Multiline = true;
            this.caja_telefonos.Name = "caja_telefonos";
            this.caja_telefonos.Size = new System.Drawing.Size(100, 55);
            this.caja_telefonos.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo";
            // 
            // cb_tipo_proveedor
            // 
            this.cb_tipo_proveedor.FormattingEnabled = true;
            this.cb_tipo_proveedor.Items.AddRange(new object[] {
            "Minorista",
            "Mayorista"});
            this.cb_tipo_proveedor.Location = new System.Drawing.Point(103, 163);
            this.cb_tipo_proveedor.Name = "cb_tipo_proveedor";
            this.cb_tipo_proveedor.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo_proveedor.TabIndex = 15;
            this.cb_tipo_proveedor.SelectionChangeCommitted += new System.EventHandler(this.cb_tipo_proveedor_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nro Proveedor";
            // 
            // caja_id_proveedor
            // 
            this.caja_id_proveedor.Enabled = false;
            this.caja_id_proveedor.Location = new System.Drawing.Point(103, 24);
            this.caja_id_proveedor.Name = "caja_id_proveedor";
            this.caja_id_proveedor.Size = new System.Drawing.Size(100, 20);
            this.caja_id_proveedor.TabIndex = 17;
            this.caja_id_proveedor.Text = "0";
            // 
            // caja_dni
            // 
            this.caja_dni.Location = new System.Drawing.Point(103, 203);
            this.caja_dni.Name = "caja_dni";
            this.caja_dni.Size = new System.Drawing.Size(100, 20);
            this.caja_dni.TabIndex = 18;
            this.caja_dni.Visible = false;
            // 
            // etiqueta_dni
            // 
            this.etiqueta_dni.AutoSize = true;
            this.etiqueta_dni.Location = new System.Drawing.Point(31, 203);
            this.etiqueta_dni.Name = "etiqueta_dni";
            this.etiqueta_dni.Size = new System.Drawing.Size(26, 13);
            this.etiqueta_dni.TabIndex = 19;
            this.etiqueta_dni.Text = "DNI";
            this.etiqueta_dni.Visible = false;
            // 
            // caja_cuit
            // 
            this.caja_cuit.Location = new System.Drawing.Point(103, 203);
            this.caja_cuit.Name = "caja_cuit";
            this.caja_cuit.Size = new System.Drawing.Size(100, 20);
            this.caja_cuit.TabIndex = 20;
            this.caja_cuit.Visible = false;
            // 
            // etiqueta_cuit
            // 
            this.etiqueta_cuit.AutoSize = true;
            this.etiqueta_cuit.Location = new System.Drawing.Point(31, 203);
            this.etiqueta_cuit.Name = "etiqueta_cuit";
            this.etiqueta_cuit.Size = new System.Drawing.Size(32, 13);
            this.etiqueta_cuit.TabIndex = 21;
            this.etiqueta_cuit.Text = "CUIT";
            this.etiqueta_cuit.Visible = false;
            // 
            // etiqueta_nro_ibb
            // 
            this.etiqueta_nro_ibb.AutoSize = true;
            this.etiqueta_nro_ibb.Location = new System.Drawing.Point(31, 238);
            this.etiqueta_nro_ibb.Name = "etiqueta_nro_ibb";
            this.etiqueta_nro_ibb.Size = new System.Drawing.Size(47, 13);
            this.etiqueta_nro_ibb.TabIndex = 22;
            this.etiqueta_nro_ibb.Text = "Nro IBB ";
            this.etiqueta_nro_ibb.Visible = false;
            // 
            // caja_nro_ibb
            // 
            this.caja_nro_ibb.Location = new System.Drawing.Point(103, 229);
            this.caja_nro_ibb.Name = "caja_nro_ibb";
            this.caja_nro_ibb.Size = new System.Drawing.Size(100, 20);
            this.caja_nro_ibb.TabIndex = 23;
            this.caja_nro_ibb.Visible = false;
            // 
            // Frm_proveedor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.caja_nro_ibb);
            this.Controls.Add(this.etiqueta_nro_ibb);
            this.Controls.Add(this.etiqueta_cuit);
            this.Controls.Add(this.caja_cuit);
            this.Controls.Add(this.etiqueta_dni);
            this.Controls.Add(this.caja_dni);
            this.Controls.Add(this.caja_id_proveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_tipo_proveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caja_telefonos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_agregar);
            this.Controls.Add(this.caja_direccion);
            this.Controls.Add(this.etiqueta_direccion);
            this.Controls.Add(this.caja_nombre);
            this.Controls.Add(this.lab);
            this.Name = "Frm_proveedor1";
            this.Text = "Frm_proveedor1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.TextBox caja_direccion;
        private System.Windows.Forms.Label etiqueta_direccion;
        private System.Windows.Forms.TextBox caja_nombre;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caja_telefonos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_tipo_proveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox caja_id_proveedor;
        private System.Windows.Forms.TextBox caja_dni;
        private System.Windows.Forms.Label etiqueta_dni;
        private System.Windows.Forms.TextBox caja_cuit;
        private System.Windows.Forms.Label etiqueta_cuit;
        private System.Windows.Forms.Label etiqueta_nro_ibb;
        private System.Windows.Forms.TextBox caja_nro_ibb;
    }
}