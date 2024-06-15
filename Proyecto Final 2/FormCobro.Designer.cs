namespace Proyecto_Final_2
{
    partial class FormCobro
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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView_OrdenVenta = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxServicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodFactura = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrdenVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(488, 369);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(92, 32);
            this.btnFinalizar.TabIndex = 101;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 33);
            this.label6.TabIndex = 99;
            this.label6.Text = "Orden de Venta";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(488, 310);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 32);
            this.btnEliminar.TabIndex = 98;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(488, 176);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 32);
            this.btnAgregar.TabIndex = 97;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView_OrdenVenta
            // 
            this.dataGridView_OrdenVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrdenVenta.Location = new System.Drawing.Point(44, 466);
            this.dataGridView_OrdenVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_OrdenVenta.Name = "dataGridView_OrdenVenta";
            this.dataGridView_OrdenVenta.RowHeadersWidth = 51;
            this.dataGridView_OrdenVenta.RowTemplate.Height = 24;
            this.dataGridView_OrdenVenta.Size = new System.Drawing.Size(592, 192);
            this.dataGridView_OrdenVenta.TabIndex = 96;
            this.dataGridView_OrdenVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OrdenVenta_CellClick);
            this.dataGridView_OrdenVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OrdenVenta_CellContentClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(236, 395);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(102, 20);
            this.txtCantidad.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 401);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Cantidad:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(236, 335);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(102, 20);
            this.txtPrecio.TabIndex = 93;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(236, 278);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(102, 20);
            this.txtNombre.TabIndex = 92;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(236, 219);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(102, 20);
            this.txtCodigo.TabIndex = 91;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Codigo:";
            // 
            // cboxServicio
            // 
            this.cboxServicio.FormattingEnabled = true;
            this.cboxServicio.Location = new System.Drawing.Point(236, 154);
            this.cboxServicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxServicio.Name = "cboxServicio";
            this.cboxServicio.Size = new System.Drawing.Size(143, 21);
            this.cboxServicio.TabIndex = 87;
            this.cboxServicio.SelectedIndexChanged += new System.EventHandler(this.cboxServicio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Servicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 102;
            this.label7.Text = "Codigo de Factura:";
            // 
            // txtCodFactura
            // 
            this.txtCodFactura.Location = new System.Drawing.Point(339, 102);
            this.txtCodFactura.Name = "txtCodFactura";
            this.txtCodFactura.Size = new System.Drawing.Size(100, 20);
            this.txtCodFactura.TabIndex = 103;
            this.txtCodFactura.TextChanged += new System.EventHandler(this.txtCodFactura_TextChanged);
            this.txtCodFactura.Leave += new System.EventHandler(this.txtCodFactura_Leave);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(488, 241);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(92, 33);
            this.btnRegresar.TabIndex = 104;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 673);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 105;
            this.label8.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(365, 673);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 106;
            this.lblTotal.Text = "0.00";
            // 
            // FormCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 609);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtCodFactura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView_OrdenVenta);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxServicio);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCobro";
            this.Text = "Orden de Venta";
            this.Load += new System.EventHandler(this.FormCobro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrdenVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView_OrdenVenta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodFactura;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
    }
}