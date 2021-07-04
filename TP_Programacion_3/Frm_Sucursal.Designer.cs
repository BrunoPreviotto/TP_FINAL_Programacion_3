
namespace TP_Programacion_3
{
    partial class Frm_Sucursal
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
            this.etiqueta_nro_sucursal = new System.Windows.Forms.Label();
            this.etiqueta_nombre = new System.Windows.Forms.Label();
            this.caja_nro_sucursal = new System.Windows.Forms.TextBox();
            this.caja_nombre = new System.Windows.Forms.TextBox();
            this.boton_guardar = new System.Windows.Forms.Button();
            this.dgv_suscursales = new System.Windows.Forms.DataGridView();
            this.boton_limpiar = new System.Windows.Forms.Button();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.boton_salir = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suscursales)).BeginInit();
            this.SuspendLayout();
            // 
            // etiqueta_nro_sucursal
            // 
            this.etiqueta_nro_sucursal.AutoSize = true;
            this.etiqueta_nro_sucursal.Location = new System.Drawing.Point(38, 40);
            this.etiqueta_nro_sucursal.Name = "etiqueta_nro_sucursal";
            this.etiqueta_nro_sucursal.Size = new System.Drawing.Size(66, 13);
            this.etiqueta_nro_sucursal.TabIndex = 0;
            this.etiqueta_nro_sucursal.Text = "Nro sucursal";
            // 
            // etiqueta_nombre
            // 
            this.etiqueta_nombre.AutoSize = true;
            this.etiqueta_nombre.Location = new System.Drawing.Point(38, 77);
            this.etiqueta_nombre.Name = "etiqueta_nombre";
            this.etiqueta_nombre.Size = new System.Drawing.Size(44, 13);
            this.etiqueta_nombre.TabIndex = 1;
            this.etiqueta_nombre.Text = "Nombre";
            // 
            // caja_nro_sucursal
            // 
            this.caja_nro_sucursal.Location = new System.Drawing.Point(135, 32);
            this.caja_nro_sucursal.Name = "caja_nro_sucursal";
            this.caja_nro_sucursal.Size = new System.Drawing.Size(100, 20);
            this.caja_nro_sucursal.TabIndex = 2;
            this.caja_nro_sucursal.Text = "0";
            // 
            // caja_nombre
            // 
            this.caja_nombre.Location = new System.Drawing.Point(135, 70);
            this.caja_nombre.Name = "caja_nombre";
            this.caja_nombre.Size = new System.Drawing.Size(100, 20);
            this.caja_nombre.TabIndex = 3;
            // 
            // boton_guardar
            // 
            this.boton_guardar.Location = new System.Drawing.Point(370, 29);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Size = new System.Drawing.Size(75, 23);
            this.boton_guardar.TabIndex = 4;
            this.boton_guardar.Text = "Guardar";
            this.boton_guardar.UseVisualStyleBackColor = true;
            this.boton_guardar.Click += new System.EventHandler(this.boton_guardar_Click);
            // 
            // dgv_suscursales
            // 
            this.dgv_suscursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_suscursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre});
            this.dgv_suscursales.Location = new System.Drawing.Point(41, 108);
            this.dgv_suscursales.Name = "dgv_suscursales";
            this.dgv_suscursales.Size = new System.Drawing.Size(404, 150);
            this.dgv_suscursales.TabIndex = 5;
            // 
            // boton_limpiar
            // 
            this.boton_limpiar.Location = new System.Drawing.Point(370, 67);
            this.boton_limpiar.Name = "boton_limpiar";
            this.boton_limpiar.Size = new System.Drawing.Size(75, 23);
            this.boton_limpiar.TabIndex = 6;
            this.boton_limpiar.Text = "Limpiar";
            this.boton_limpiar.UseVisualStyleBackColor = true;
            this.boton_limpiar.Click += new System.EventHandler(this.boton_limpiar_Click);
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Location = new System.Drawing.Point(41, 285);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(75, 23);
            this.boton_eliminar.TabIndex = 7;
            this.boton_eliminar.Text = "Eliminar";
            this.boton_eliminar.UseVisualStyleBackColor = true;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // boton_salir
            // 
            this.boton_salir.Location = new System.Drawing.Point(370, 285);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(75, 23);
            this.boton_salir.TabIndex = 8;
            this.boton_salir.Text = "Salir";
            this.boton_salir.UseVisualStyleBackColor = true;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Nro sucursal";
            this.id.Name = "id";
            this.id.Width = 175;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 175;
            // 
            // Frm_Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 331);
            this.Controls.Add(this.boton_salir);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_limpiar);
            this.Controls.Add(this.dgv_suscursales);
            this.Controls.Add(this.boton_guardar);
            this.Controls.Add(this.caja_nombre);
            this.Controls.Add(this.caja_nro_sucursal);
            this.Controls.Add(this.etiqueta_nombre);
            this.Controls.Add(this.etiqueta_nro_sucursal);
            this.Name = "Frm_Sucursal";
            this.Text = "Frm_Sucursal";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_suscursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiqueta_nro_sucursal;
        private System.Windows.Forms.Label etiqueta_nombre;
        private System.Windows.Forms.TextBox caja_nro_sucursal;
        private System.Windows.Forms.TextBox caja_nombre;
        private System.Windows.Forms.Button boton_guardar;
        private System.Windows.Forms.DataGridView dgv_suscursales;
        private System.Windows.Forms.Button boton_limpiar;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.Button boton_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}