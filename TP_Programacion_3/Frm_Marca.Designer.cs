
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // caja_nombre
            // 
            this.caja_nombre.Location = new System.Drawing.Point(100, 21);
            this.caja_nombre.Name = "caja_nombre";
            this.caja_nombre.Size = new System.Drawing.Size(100, 20);
            this.caja_nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // caja_descripcion
            // 
            this.caja_descripcion.Location = new System.Drawing.Point(100, 69);
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
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Location = new System.Drawing.Point(278, 66);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(75, 23);
            this.boton_eliminar.TabIndex = 5;
            this.boton_eliminar.Text = "Eliminar";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            // 
            // Frm_Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_agregar);
            this.Controls.Add(this.caja_descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caja_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Marca";
            this.Text = "Frm_Marca";
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
    }
}