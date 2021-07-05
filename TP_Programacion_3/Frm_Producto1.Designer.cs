
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
            this.dgv_minorista = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_mayorista = new System.Windows.Forms.DataGridView();
            this.caja_precio = new System.Windows.Forms.TextBox();
            this.etiqueta_precio = new System.Windows.Forms.Label();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.boton_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre_mayorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca_mayorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_mayorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_minorista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mayorista)).BeginInit();
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
            // dgv_minorista
            // 
            this.dgv_minorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_minorista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.marca,
            this.precio});
            this.dgv_minorista.Location = new System.Drawing.Point(69, 125);
            this.dgv_minorista.Name = "dgv_minorista";
            this.dgv_minorista.Size = new System.Drawing.Size(510, 193);
            this.dgv_minorista.TabIndex = 4;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // dgv_mayorista
            // 
            this.dgv_mayorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mayorista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_mayorista,
            this.marca_mayorista,
            this.precio_mayorista});
            this.dgv_mayorista.Location = new System.Drawing.Point(69, 349);
            this.dgv_mayorista.Name = "dgv_mayorista";
            this.dgv_mayorista.Size = new System.Drawing.Size(510, 159);
            this.dgv_mayorista.TabIndex = 5;
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
            this.boton_buscar.Location = new System.Drawing.Point(364, 61);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(75, 23);
            this.boton_buscar.TabIndex = 8;
            this.boton_buscar.Text = "Buscar";
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // boton_salir
            // 
            this.boton_salir.Location = new System.Drawing.Point(500, 61);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(75, 23);
            this.boton_salir.TabIndex = 10;
            this.boton_salir.Text = "Salir";
            this.boton_salir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Proveedor Minorista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Proveedor Mayorista";
            // 
            // nombre_mayorista
            // 
            this.nombre_mayorista.DataPropertyName = "nombre";
            this.nombre_mayorista.HeaderText = "Nombre";
            this.nombre_mayorista.Name = "nombre_mayorista";
            // 
            // marca_mayorista
            // 
            this.marca_mayorista.DataPropertyName = "marca";
            this.marca_mayorista.HeaderText = "Marca";
            this.marca_mayorista.Name = "marca_mayorista";
            // 
            // precio_mayorista
            // 
            this.precio_mayorista.DataPropertyName = "precio";
            this.precio_mayorista.HeaderText = "Precio";
            this.precio_mayorista.Name = "precio_mayorista";
            // 
            // Frm_Producto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 520);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_salir);
            this.Controls.Add(this.boton_buscar);
            this.Controls.Add(this.etiqueta_precio);
            this.Controls.Add(this.caja_precio);
            this.Controls.Add(this.dgv_mayorista);
            this.Controls.Add(this.dgv_minorista);
            this.Controls.Add(this.caja_marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caja_producto);
            this.Controls.Add(this.etiqueta_producto);
            this.Name = "Frm_Producto1";
            this.Text = "Frm_Producto1";
            this.Load += new System.EventHandler(this.Frm_Producto1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_minorista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mayorista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiqueta_producto;
        private System.Windows.Forms.TextBox caja_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox caja_marca;
        private System.Windows.Forms.DataGridView dgv_minorista;
        private System.Windows.Forms.DataGridView dgv_mayorista;
        private System.Windows.Forms.TextBox caja_precio;
        private System.Windows.Forms.Label etiqueta_precio;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Button boton_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_mayorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca_mayorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_mayorista;
    }
}