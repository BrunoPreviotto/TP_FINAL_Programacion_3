﻿
namespace TP_Programacion_3
{
    partial class Frm_Marca
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
            this.caja_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.caja_descripcion = new System.Windows.Forms.TextBox();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.caja_id_marca = new System.Windows.Forms.TextBox();
            this.boton_limpiar = new System.Windows.Forms.Button();
            this.boton_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // caja_nombre
            // 
            this.caja_nombre.Location = new System.Drawing.Point(103, 57);
            this.caja_nombre.Name = "caja_nombre";
            this.caja_nombre.Size = new System.Drawing.Size(100, 20);
            this.caja_nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripcion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // caja_descripcion
            // 
            this.caja_descripcion.Location = new System.Drawing.Point(103, 92);
            this.caja_descripcion.Multiline = true;
            this.caja_descripcion.Name = "caja_descripcion";
            this.caja_descripcion.Size = new System.Drawing.Size(137, 75);
            this.caja_descripcion.TabIndex = 3;
            // 
            // boton_agregar
            // 
            this.boton_agregar.Location = new System.Drawing.Point(278, 23);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(75, 23);
            this.boton_agregar.TabIndex = 4;
            this.boton_agregar.Text = "Agregar";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Location = new System.Drawing.Point(278, 52);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(75, 23);
            this.boton_eliminar.TabIndex = 5;
            this.boton_eliminar.Text = "Eliminar";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nro Marca";
            // 
            // caja_id_marca
            // 
            this.caja_id_marca.Enabled = false;
            this.caja_id_marca.Location = new System.Drawing.Point(103, 23);
            this.caja_id_marca.Name = "caja_id_marca";
            this.caja_id_marca.Size = new System.Drawing.Size(100, 20);
            this.caja_id_marca.TabIndex = 1;
            this.caja_id_marca.Text = "0";
            // 
            // boton_limpiar
            // 
            this.boton_limpiar.Location = new System.Drawing.Point(278, 81);
            this.boton_limpiar.Name = "boton_limpiar";
            this.boton_limpiar.Size = new System.Drawing.Size(75, 23);
            this.boton_limpiar.TabIndex = 9;
            this.boton_limpiar.Text = "Limpiar";
            this.boton_limpiar.UseVisualStyleBackColor = true;
            this.boton_limpiar.Click += new System.EventHandler(this.boton_limpiar_Click);
            // 
            // boton_salir
            // 
            this.boton_salir.Location = new System.Drawing.Point(278, 110);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(75, 23);
            this.boton_salir.TabIndex = 10;
            this.boton_salir.Text = "Salir";
            this.boton_salir.UseVisualStyleBackColor = true;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // Frm_Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 236);
            this.Controls.Add(this.boton_salir);
            this.Controls.Add(this.boton_limpiar);
            this.Controls.Add(this.caja_id_marca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_agregar);
            this.Controls.Add(this.caja_descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caja_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Marca";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR MARCA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caja_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox caja_descripcion;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox caja_id_marca;
        private System.Windows.Forms.Button boton_limpiar;
        private System.Windows.Forms.Button boton_salir;
    }
}