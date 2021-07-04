
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // 
            // caja_direccion
            // 
            this.caja_direccion.Location = new System.Drawing.Point(103, 81);
            this.caja_direccion.Name = "caja_direccion";
            this.caja_direccion.Size = new System.Drawing.Size(100, 20);
            this.caja_direccion.TabIndex = 9;
            // 
            // etiqueta_direccion
            // 
            this.etiqueta_direccion.AutoSize = true;
            this.etiqueta_direccion.Location = new System.Drawing.Point(31, 88);
            this.etiqueta_direccion.Name = "etiqueta_direccion";
            this.etiqueta_direccion.Size = new System.Drawing.Size(52, 13);
            this.etiqueta_direccion.TabIndex = 8;
            this.etiqueta_direccion.Text = "Direccion";
            // 
            // caja_nombre
            // 
            this.caja_nombre.Location = new System.Drawing.Point(103, 33);
            this.caja_nombre.Name = "caja_nombre";
            this.caja_nombre.Size = new System.Drawing.Size(100, 20);
            this.caja_nombre.TabIndex = 7;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(31, 40);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(44, 13);
            this.lab.TabIndex = 6;
            this.lab.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Telefono/s";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 126);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 55);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Minorista",
            "Mayorista"});
            this.comboBox1.Location = new System.Drawing.Point(82, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // Frm_proveedor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}