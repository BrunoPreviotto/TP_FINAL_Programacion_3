﻿
namespace TP_Programacion_3
{
    partial class Frm_AgregarProducto
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
            this.caja_descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.caja_marca = new System.Windows.Forms.TextBox();
            this.etiqueta_direccion = new System.Windows.Forms.Label();
            this.caja_nombre = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.caja_precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.caja_id_producto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // caja_descripcion
            // 
            this.caja_descripcion.Location = new System.Drawing.Point(117, 94);
            this.caja_descripcion.Multiline = true;
            this.caja_descripcion.Name = "caja_descripcion";
            this.caja_descripcion.Size = new System.Drawing.Size(100, 55);
            this.caja_descripcion.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Descripcion";
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Location = new System.Drawing.Point(295, 65);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(75, 23);
            this.boton_eliminar.TabIndex = 21;
            this.boton_eliminar.Text = "Eliminar";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            // 
            // boton_agregar
            // 
            this.boton_agregar.Location = new System.Drawing.Point(295, 22);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(75, 23);
            this.boton_agregar.TabIndex = 20;
            this.boton_agregar.Text = "Agregar";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // caja_marca
            // 
            this.caja_marca.Location = new System.Drawing.Point(117, 68);
            this.caja_marca.Name = "caja_marca";
            this.caja_marca.Size = new System.Drawing.Size(100, 20);
            this.caja_marca.TabIndex = 19;
            // 
            // etiqueta_direccion
            // 
            this.etiqueta_direccion.AutoSize = true;
            this.etiqueta_direccion.Location = new System.Drawing.Point(45, 68);
            this.etiqueta_direccion.Name = "etiqueta_direccion";
            this.etiqueta_direccion.Size = new System.Drawing.Size(37, 13);
            this.etiqueta_direccion.TabIndex = 18;
            this.etiqueta_direccion.Text = "Marca";
            // 
            // caja_nombre
            // 
            this.caja_nombre.Location = new System.Drawing.Point(117, 42);
            this.caja_nombre.Name = "caja_nombre";
            this.caja_nombre.Size = new System.Drawing.Size(100, 20);
            this.caja_nombre.TabIndex = 17;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(45, 49);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(44, 13);
            this.lab.TabIndex = 16;
            this.lab.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Precio";
            // 
            // caja_precio
            // 
            this.caja_precio.Location = new System.Drawing.Point(117, 155);
            this.caja_precio.Name = "caja_precio";
            this.caja_precio.Size = new System.Drawing.Size(100, 20);
            this.caja_precio.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nro Producto";
            // 
            // caja_id_producto
            // 
            this.caja_id_producto.Enabled = false;
            this.caja_id_producto.Location = new System.Drawing.Point(117, 16);
            this.caja_id_producto.Name = "caja_id_producto";
            this.caja_id_producto.Size = new System.Drawing.Size(100, 20);
            this.caja_id_producto.TabIndex = 29;
            this.caja_id_producto.Text = "0";
            // 
            // Frm_AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 315);
            this.Controls.Add(this.caja_id_producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.caja_precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.caja_descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_agregar);
            this.Controls.Add(this.caja_marca);
            this.Controls.Add(this.etiqueta_direccion);
            this.Controls.Add(this.caja_nombre);
            this.Controls.Add(this.lab);
            this.Name = "Frm_AgregarProducto";
            this.Text = "Frm_AgregarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox caja_descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.TextBox caja_marca;
        private System.Windows.Forms.Label etiqueta_direccion;
        private System.Windows.Forms.TextBox caja_nombre;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox caja_precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox caja_id_producto;
    }
}