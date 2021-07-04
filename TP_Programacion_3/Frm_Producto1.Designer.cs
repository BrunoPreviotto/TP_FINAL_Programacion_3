
namespace TP_Programacion_3
{
    partial class Frm_Producto1
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
            this.etiqueta_producto = new System.Windows.Forms.Label();
            this.caja_producto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.caja_marca = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.caja_precio = new System.Windows.Forms.TextBox();
            this.etiqueta_precio = new System.Windows.Forms.Label();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.boton_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // etiqueta_producto
            // 
            this.etiqueta_producto.AutoSize = true;
            this.etiqueta_producto.Location = new System.Drawing.Point(12, 19);
            this.etiqueta_producto.Name = "etiqueta_producto";
            this.etiqueta_producto.Size = new System.Drawing.Size(50, 13);
            this.etiqueta_producto.TabIndex = 0;
            this.etiqueta_producto.Text = "Producto";
            // 
            // caja_producto
            // 
            this.caja_producto.Location = new System.Drawing.Point(69, 12);
            this.caja_producto.Name = "caja_producto";
            this.caja_producto.Size = new System.Drawing.Size(100, 20);
            this.caja_producto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // caja_marca
            // 
            this.caja_marca.Location = new System.Drawing.Point(69, 37);
            this.caja_marca.Name = "caja_marca";
            this.caja_marca.Size = new System.Drawing.Size(100, 20);
            this.caja_marca.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 193);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(69, 349);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(510, 159);
            this.dataGridView2.TabIndex = 5;
            // 
            // caja_precio
            // 
            this.caja_precio.Location = new System.Drawing.Point(69, 64);
            this.caja_precio.Name = "caja_precio";
            this.caja_precio.Size = new System.Drawing.Size(100, 20);
            this.caja_precio.TabIndex = 6;
            // 
            // etiqueta_precio
            // 
            this.etiqueta_precio.AutoSize = true;
            this.etiqueta_precio.Location = new System.Drawing.Point(12, 71);
            this.etiqueta_precio.Name = "etiqueta_precio";
            this.etiqueta_precio.Size = new System.Drawing.Size(37, 13);
            this.etiqueta_precio.TabIndex = 7;
            this.etiqueta_precio.Text = "Precio";
            // 
            // boton_buscar
            // 
            this.boton_buscar.Location = new System.Drawing.Point(309, 61);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(75, 23);
            this.boton_buscar.TabIndex = 8;
            this.boton_buscar.Text = "Buscar";
            this.boton_buscar.UseVisualStyleBackColor = true;
            // 
            // boton_salir
            // 
            this.boton_salir.Location = new System.Drawing.Point(520, 61);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(75, 23);
            this.boton_salir.TabIndex = 10;
            this.boton_salir.Text = "Salir";
            this.boton_salir.UseVisualStyleBackColor = true;
            // 
            // Frm_Producto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 520);
            this.Controls.Add(this.boton_salir);
            this.Controls.Add(this.boton_buscar);
            this.Controls.Add(this.etiqueta_precio);
            this.Controls.Add(this.caja_precio);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.caja_marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caja_producto);
            this.Controls.Add(this.etiqueta_producto);
            this.Name = "Frm_Producto1";
            this.Text = "Frm_Producto1";
            this.Load += new System.EventHandler(this.Frm_Producto1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiqueta_producto;
        private System.Windows.Forms.TextBox caja_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox caja_marca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox caja_precio;
        private System.Windows.Forms.Label etiqueta_precio;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Button boton_salir;
    }
}