namespace Proyecto_Final_2
{
    partial class Form_ServiciosEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ServiciosEmpleado));
            this.tbcServicios = new System.Windows.Forms.TabControl();
            this.tpConsultar = new System.Windows.Forms.TabPage();
            this.gboxConsulta = new System.Windows.Forms.GroupBox();
            this.rbNombre_Consulta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCodigo_Consulta = new System.Windows.Forms.RadioButton();
            this.btnSalir_Consulta = new System.Windows.Forms.Button();
            this.btnRegresar_Consulta = new System.Windows.Forms.Button();
            this.btnConfirmar_Consulta = new System.Windows.Forms.Button();
            this.txtNombre_Consulta = new System.Windows.Forms.TextBox();
            this.txtCodigo_Consulta = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lblNombre_Consultar = new System.Windows.Forms.Label();
            this.lblCodigo_Consultar = new System.Windows.Forms.Label();
            this.tbcServicios.SuspendLayout();
            this.tpConsultar.SuspendLayout();
            this.gboxConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcServicios
            // 
            this.tbcServicios.Controls.Add(this.tpConsultar);
            this.tbcServicios.Location = new System.Drawing.Point(-5, 0);
            this.tbcServicios.Name = "tbcServicios";
            this.tbcServicios.SelectedIndex = 0;
            this.tbcServicios.Size = new System.Drawing.Size(1195, 562);
            this.tbcServicios.TabIndex = 3;
            // 
            // tpConsultar
            // 
            this.tpConsultar.Controls.Add(this.gboxConsulta);
            this.tpConsultar.Controls.Add(this.btnSalir_Consulta);
            this.tpConsultar.Controls.Add(this.btnRegresar_Consulta);
            this.tpConsultar.Controls.Add(this.btnConfirmar_Consulta);
            this.tpConsultar.Controls.Add(this.txtNombre_Consulta);
            this.tpConsultar.Controls.Add(this.txtCodigo_Consulta);
            this.tpConsultar.Controls.Add(this.label24);
            this.tpConsultar.Controls.Add(this.dgvConsulta);
            this.tpConsultar.Controls.Add(this.lblNombre_Consultar);
            this.tpConsultar.Controls.Add(this.lblCodigo_Consultar);
            this.tpConsultar.Location = new System.Drawing.Point(4, 25);
            this.tpConsultar.Name = "tpConsultar";
            this.tpConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsultar.Size = new System.Drawing.Size(1187, 533);
            this.tpConsultar.TabIndex = 1;
            this.tpConsultar.Text = "Consultar";
            this.tpConsultar.UseVisualStyleBackColor = true;
            // 
            // gboxConsulta
            // 
            this.gboxConsulta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gboxConsulta.Controls.Add(this.rbNombre_Consulta);
            this.gboxConsulta.Controls.Add(this.label1);
            this.gboxConsulta.Controls.Add(this.rbCodigo_Consulta);
            this.gboxConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxConsulta.Location = new System.Drawing.Point(57, 141);
            this.gboxConsulta.Name = "gboxConsulta";
            this.gboxConsulta.Size = new System.Drawing.Size(334, 142);
            this.gboxConsulta.TabIndex = 150;
            this.gboxConsulta.TabStop = false;
            // 
            // rbNombre_Consulta
            // 
            this.rbNombre_Consulta.AutoSize = true;
            this.rbNombre_Consulta.Location = new System.Drawing.Point(146, 85);
            this.rbNombre_Consulta.Name = "rbNombre_Consulta";
            this.rbNombre_Consulta.Size = new System.Drawing.Size(129, 20);
            this.rbNombre_Consulta.TabIndex = 149;
            this.rbNombre_Consulta.TabStop = true;
            this.rbNombre_Consulta.Text = "Nombre Servicio";
            this.rbNombre_Consulta.UseVisualStyleBackColor = true;
            this.rbNombre_Consulta.CheckedChanged += new System.EventHandler(this.rbNombre_Consulta_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 147;
            this.label1.Text = "Consultar por:";
            // 
            // rbCodigo_Consulta
            // 
            this.rbCodigo_Consulta.AutoSize = true;
            this.rbCodigo_Consulta.Location = new System.Drawing.Point(146, 43);
            this.rbCodigo_Consulta.Name = "rbCodigo_Consulta";
            this.rbCodigo_Consulta.Size = new System.Drawing.Size(124, 20);
            this.rbCodigo_Consulta.TabIndex = 148;
            this.rbCodigo_Consulta.TabStop = true;
            this.rbCodigo_Consulta.Text = "Codigo Servicio";
            this.rbCodigo_Consulta.UseVisualStyleBackColor = true;
            this.rbCodigo_Consulta.CheckedChanged += new System.EventHandler(this.rbCodigo_Consulta_CheckedChanged);
            // 
            // btnSalir_Consulta
            // 
            this.btnSalir_Consulta.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir_Consulta.Image")));
            this.btnSalir_Consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir_Consulta.Location = new System.Drawing.Point(940, 435);
            this.btnSalir_Consulta.Name = "btnSalir_Consulta";
            this.btnSalir_Consulta.Size = new System.Drawing.Size(156, 36);
            this.btnSalir_Consulta.TabIndex = 146;
            this.btnSalir_Consulta.Text = "Salir";
            this.btnSalir_Consulta.UseVisualStyleBackColor = true;
            this.btnSalir_Consulta.Click += new System.EventHandler(this.btnSalir_Consulta_Click);
            // 
            // btnRegresar_Consulta
            // 
            this.btnRegresar_Consulta.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar_Consulta.Image")));
            this.btnRegresar_Consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar_Consulta.Location = new System.Drawing.Point(757, 435);
            this.btnRegresar_Consulta.Name = "btnRegresar_Consulta";
            this.btnRegresar_Consulta.Size = new System.Drawing.Size(156, 36);
            this.btnRegresar_Consulta.TabIndex = 145;
            this.btnRegresar_Consulta.Text = "Regresar";
            this.btnRegresar_Consulta.UseVisualStyleBackColor = true;
            this.btnRegresar_Consulta.Click += new System.EventHandler(this.btnRegresar_Consulta_Click);
            // 
            // btnConfirmar_Consulta
            // 
            this.btnConfirmar_Consulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar_Consulta.Image")));
            this.btnConfirmar_Consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar_Consulta.Location = new System.Drawing.Point(571, 435);
            this.btnConfirmar_Consulta.Name = "btnConfirmar_Consulta";
            this.btnConfirmar_Consulta.Size = new System.Drawing.Size(156, 36);
            this.btnConfirmar_Consulta.TabIndex = 144;
            this.btnConfirmar_Consulta.Text = "Confirmar";
            this.btnConfirmar_Consulta.UseVisualStyleBackColor = true;
            this.btnConfirmar_Consulta.Click += new System.EventHandler(this.btnConfirmar_Consulta_Click);
            // 
            // txtNombre_Consulta
            // 
            this.txtNombre_Consulta.Location = new System.Drawing.Point(221, 399);
            this.txtNombre_Consulta.Name = "txtNombre_Consulta";
            this.txtNombre_Consulta.ReadOnly = true;
            this.txtNombre_Consulta.Size = new System.Drawing.Size(170, 22);
            this.txtNombre_Consulta.TabIndex = 134;
            // 
            // txtCodigo_Consulta
            // 
            this.txtCodigo_Consulta.Location = new System.Drawing.Point(221, 346);
            this.txtCodigo_Consulta.Name = "txtCodigo_Consulta";
            this.txtCodigo_Consulta.ReadOnly = true;
            this.txtCodigo_Consulta.Size = new System.Drawing.Size(170, 22);
            this.txtCodigo_Consulta.TabIndex = 133;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(424, 42);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(276, 48);
            this.label24.TabIndex = 132;
            this.label24.Text = "Consultar Servicio";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(531, 151);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(604, 251);
            this.dgvConsulta.TabIndex = 131;
            // 
            // lblNombre_Consultar
            // 
            this.lblNombre_Consultar.AutoSize = true;
            this.lblNombre_Consultar.Location = new System.Drawing.Point(54, 405);
            this.lblNombre_Consultar.Name = "lblNombre_Consultar";
            this.lblNombre_Consultar.Size = new System.Drawing.Size(111, 16);
            this.lblNombre_Consultar.TabIndex = 127;
            this.lblNombre_Consultar.Text = "Nombre Servicio:";
            // 
            // lblCodigo_Consultar
            // 
            this.lblCodigo_Consultar.AutoSize = true;
            this.lblCodigo_Consultar.Location = new System.Drawing.Point(54, 352);
            this.lblCodigo_Consultar.Name = "lblCodigo_Consultar";
            this.lblCodigo_Consultar.Size = new System.Drawing.Size(106, 16);
            this.lblCodigo_Consultar.TabIndex = 126;
            this.lblCodigo_Consultar.Text = "Codigo Servicio:";
            // 
            // Form_ServiciosEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 563);
            this.Controls.Add(this.tbcServicios);
            this.Name = "Form_ServiciosEmpleado";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Form_ServiciosEmpleado_Load);
            this.tbcServicios.ResumeLayout(false);
            this.tpConsultar.ResumeLayout(false);
            this.tpConsultar.PerformLayout();
            this.gboxConsulta.ResumeLayout(false);
            this.gboxConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcServicios;
        private System.Windows.Forms.TabPage tpConsultar;
        private System.Windows.Forms.GroupBox gboxConsulta;
        private System.Windows.Forms.RadioButton rbNombre_Consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCodigo_Consulta;
        private System.Windows.Forms.Button btnSalir_Consulta;
        private System.Windows.Forms.Button btnRegresar_Consulta;
        private System.Windows.Forms.Button btnConfirmar_Consulta;
        private System.Windows.Forms.TextBox txtNombre_Consulta;
        private System.Windows.Forms.TextBox txtCodigo_Consulta;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblNombre_Consultar;
        private System.Windows.Forms.Label lblCodigo_Consultar;
    }
}