
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
            this.dgv_minorista = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_mayorista = new System.Windows.Forms.DataGridView();
            this.nombre_mayorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca_mayorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_mayorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.boton_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boton_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_minorista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mayorista)).BeginInit();
            this.SuspendLayout();
            // 
            // etiqueta_producto
            // 
            this.etiqueta_producto.AutoSize = true;
            this.etiqueta_producto.Location = new System.Drawing.Point(13, 71);
            this.etiqueta_producto.Name = "etiqueta_producto";
            this.etiqueta_producto.Size = new System.Drawing.Size(50, 13);
            this.etiqueta_producto.TabIndex = 6;
            this.etiqueta_producto.Text = "Producto";
            // 
            // caja_producto
            // 
            this.caja_producto.Location = new System.Drawing.Point(69, 64);
            this.caja_producto.Name = "caja_producto";
            this.caja_producto.Size = new System.Drawing.Size(100, 20);
            this.caja_producto.TabIndex = 1;
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
            this.nombre.Width = 155;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.Width = 155;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.Width = 155;
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
            this.dgv_mayorista.Size = new System.Drawing.Size(510, 193);
            this.dgv_mayorista.TabIndex = 5;
            // 
            // nombre_mayorista
            // 
            this.nombre_mayorista.DataPropertyName = "nombre";
            this.nombre_mayorista.HeaderText = "Nombre";
            this.nombre_mayorista.Name = "nombre_mayorista";
            this.nombre_mayorista.Width = 155;
            // 
            // marca_mayorista
            // 
            this.marca_mayorista.DataPropertyName = "marca";
            this.marca_mayorista.HeaderText = "Marca";
            this.marca_mayorista.Name = "marca_mayorista";
            this.marca_mayorista.Width = 155;
            // 
            // precio_mayorista
            // 
            this.precio_mayorista.DataPropertyName = "precio";
            this.precio_mayorista.HeaderText = "Precio";
            this.precio_mayorista.Name = "precio_mayorista";
            this.precio_mayorista.Width = 155;
            // 
            // boton_buscar
            // 
            this.boton_buscar.Location = new System.Drawing.Point(338, 61);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(75, 23);
            this.boton_buscar.TabIndex = 2;
            this.boton_buscar.Text = "Buscar";
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // boton_salir
            // 
            this.boton_salir.Location = new System.Drawing.Point(500, 61);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(75, 23);
            this.boton_salir.TabIndex = 3;
            this.boton_salir.Text = "Salir";
            this.boton_salir.UseVisualStyleBackColor = true;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Proveedor Minorista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Proveedor Mayorista";
            // 
            // boton_limpiar
            // 
            this.boton_limpiar.Location = new System.Drawing.Point(419, 61);
            this.boton_limpiar.Name = "boton_limpiar";
            this.boton_limpiar.Size = new System.Drawing.Size(75, 23);
            this.boton_limpiar.TabIndex = 9;
            this.boton_limpiar.Text = "Limpiar";
            this.boton_limpiar.UseVisualStyleBackColor = true;
            this.boton_limpiar.Click += new System.EventHandler(this.boton_limpiar_Click);
            // 
            // Frm_Producto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 560);
            this.Controls.Add(this.boton_limpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_salir);
            this.Controls.Add(this.boton_buscar);
            this.Controls.Add(this.dgv_mayorista);
            this.Controls.Add(this.dgv_minorista);
            this.Controls.Add(this.caja_producto);
            this.Controls.Add(this.etiqueta_producto);
            this.Name = "Frm_Producto1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR PRODUCTO";
            this.Load += new System.EventHandler(this.Frm_Producto1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_minorista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mayorista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiqueta_producto;
        private System.Windows.Forms.TextBox caja_producto;
        private System.Windows.Forms.DataGridView dgv_minorista;
        private System.Windows.Forms.DataGridView dgv_mayorista;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Button boton_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_mayorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca_mayorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_mayorista;
        private System.Windows.Forms.Button boton_limpiar;
    }
}