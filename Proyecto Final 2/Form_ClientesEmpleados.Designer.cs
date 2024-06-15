namespace Proyecto_Final_2
{
    partial class Form_ClientesEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ClientesEmpleados));
            this.tbcClientes = new System.Windows.Forms.TabControl();
            this.tpAgregar = new System.Windows.Forms.TabPage();
            this.txtTelefono_Agregar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento_Agregar = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion_Agregar = new System.Windows.Forms.TextBox();
            this.txtApellido_Agregar = new System.Windows.Forms.TextBox();
            this.txtNombre_Agregar = new System.Windows.Forms.TextBox();
            this.btnSalir_Agregar = new System.Windows.Forms.Button();
            this.btnRegresar_Agregar = new System.Windows.Forms.Button();
            this.btnConfirmar_Agregar = new System.Windows.Forms.Button();
            this.dgvAgregar = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.tbcClientes.SuspendLayout();
            this.tpAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).BeginInit();
            this.tpConsultar.SuspendLayout();
            this.gboxConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcClientes
            // 
            this.tbcClientes.Controls.Add(this.tpAgregar);
            this.tbcClientes.Controls.Add(this.tpConsultar);
            this.tbcClientes.Location = new System.Drawing.Point(-4, 2);
            this.tbcClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcClientes.Name = "tbcClientes";
            this.tbcClientes.SelectedIndex = 0;
            this.tbcClientes.Size = new System.Drawing.Size(896, 457);
            this.tbcClientes.TabIndex = 2;
            this.tbcClientes.SelectedIndexChanged += new System.EventHandler(this.tbcClientes_SelectedIndexChanged);
            // 
            // tpAgregar
            // 
            this.tpAgregar.Controls.Add(this.txtTelefono_Agregar);
            this.tpAgregar.Controls.Add(this.label13);
            this.tpAgregar.Controls.Add(this.dtpFechaNacimiento_Agregar);
            this.tpAgregar.Controls.Add(this.txtDireccion_Agregar);
            this.tpAgregar.Controls.Add(this.txtApellido_Agregar);
            this.tpAgregar.Controls.Add(this.txtNombre_Agregar);
            this.tpAgregar.Controls.Add(this.btnSalir_Agregar);
            this.tpAgregar.Controls.Add(this.btnRegresar_Agregar);
            this.tpAgregar.Controls.Add(this.btnConfirmar_Agregar);
            this.tpAgregar.Controls.Add(this.dgvAgregar);
            this.tpAgregar.Controls.Add(this.label6);
            this.tpAgregar.Controls.Add(this.label5);
            this.tpAgregar.Controls.Add(this.label4);
            this.tpAgregar.Controls.Add(this.label3);
            this.tpAgregar.Controls.Add(this.label7);
            this.tpAgregar.Location = new System.Drawing.Point(4, 22);
            this.tpAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpAgregar.Name = "tpAgregar";
            this.tpAgregar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpAgregar.Size = new System.Drawing.Size(888, 431);
            this.tpAgregar.TabIndex = 0;
            this.tpAgregar.Text = "Agregar";
            this.tpAgregar.UseVisualStyleBackColor = true;
            // 
            // txtTelefono_Agregar
            // 
            this.txtTelefono_Agregar.Location = new System.Drawing.Point(162, 304);
            this.txtTelefono_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono_Agregar.Name = "txtTelefono_Agregar";
            this.txtTelefono_Agregar.Size = new System.Drawing.Size(128, 20);
            this.txtTelefono_Agregar.TabIndex = 104;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 309);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 103;
            this.label13.Text = "Teléfono:";
            // 
            // dtpFechaNacimiento_Agregar
            // 
            this.dtpFechaNacimiento_Agregar.Location = new System.Drawing.Point(162, 262);
            this.dtpFechaNacimiento_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaNacimiento_Agregar.Name = "dtpFechaNacimiento_Agregar";
            this.dtpFechaNacimiento_Agregar.Size = new System.Drawing.Size(197, 20);
            this.dtpFechaNacimiento_Agregar.TabIndex = 102;
            // 
            // txtDireccion_Agregar
            // 
            this.txtDireccion_Agregar.Location = new System.Drawing.Point(162, 215);
            this.txtDireccion_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion_Agregar.Name = "txtDireccion_Agregar";
            this.txtDireccion_Agregar.Size = new System.Drawing.Size(128, 20);
            this.txtDireccion_Agregar.TabIndex = 101;
            // 
            // txtApellido_Agregar
            // 
            this.txtApellido_Agregar.Location = new System.Drawing.Point(162, 168);
            this.txtApellido_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido_Agregar.Name = "txtApellido_Agregar";
            this.txtApellido_Agregar.Size = new System.Drawing.Size(128, 20);
            this.txtApellido_Agregar.TabIndex = 100;
            // 
            // txtNombre_Agregar
            // 
            this.txtNombre_Agregar.Location = new System.Drawing.Point(162, 124);
            this.txtNombre_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre_Agregar.Name = "txtNombre_Agregar";
            this.txtNombre_Agregar.Size = new System.Drawing.Size(128, 20);
            this.txtNombre_Agregar.TabIndex = 99;
            // 
            // btnSalir_Agregar
            // 
            this.btnSalir_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir_Agregar.Image")));
            this.btnSalir_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir_Agregar.Location = new System.Drawing.Point(710, 353);
            this.btnSalir_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir_Agregar.Name = "btnSalir_Agregar";
            this.btnSalir_Agregar.Size = new System.Drawing.Size(117, 29);
            this.btnSalir_Agregar.TabIndex = 97;
            this.btnSalir_Agregar.Text = "Salir";
            this.btnSalir_Agregar.UseVisualStyleBackColor = true;
            this.btnSalir_Agregar.Click += new System.EventHandler(this.btnSalir_Agregar_Click);
            // 
            // btnRegresar_Agregar
            // 
            this.btnRegresar_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar_Agregar.Image")));
            this.btnRegresar_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar_Agregar.Location = new System.Drawing.Point(573, 353);
            this.btnRegresar_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresar_Agregar.Name = "btnRegresar_Agregar";
            this.btnRegresar_Agregar.Size = new System.Drawing.Size(117, 29);
            this.btnRegresar_Agregar.TabIndex = 96;
            this.btnRegresar_Agregar.Text = "Regresar";
            this.btnRegresar_Agregar.UseVisualStyleBackColor = true;
            this.btnRegresar_Agregar.Click += new System.EventHandler(this.btnRegresar_Agregar_Click);
            // 
            // btnConfirmar_Agregar
            // 
            this.btnConfirmar_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar_Agregar.Image")));
            this.btnConfirmar_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar_Agregar.Location = new System.Drawing.Point(434, 353);
            this.btnConfirmar_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmar_Agregar.Name = "btnConfirmar_Agregar";
            this.btnConfirmar_Agregar.Size = new System.Drawing.Size(117, 29);
            this.btnConfirmar_Agregar.TabIndex = 95;
            this.btnConfirmar_Agregar.Text = "Confirmar";
            this.btnConfirmar_Agregar.UseVisualStyleBackColor = true;
            this.btnConfirmar_Agregar.Click += new System.EventHandler(this.btnConfirmar_Agregar_Click);
            // 
            // dgvAgregar
            // 
            this.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregar.Location = new System.Drawing.Point(398, 124);
            this.dgvAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAgregar.Name = "dgvAgregar";
            this.dgvAgregar.RowHeadersWidth = 51;
            this.dgvAgregar.RowTemplate.Height = 24;
            this.dgvAgregar.Size = new System.Drawing.Size(453, 204);
            this.dgvAgregar.TabIndex = 94;
            this.dgvAgregar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgregar_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Dirección Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Apellido Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Nombre Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(341, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 38);
            this.label7.TabIndex = 86;
            this.label7.Text = "Agregar Cliente";
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
            this.tpConsultar.Location = new System.Drawing.Point(4, 22);
            this.tpConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpConsultar.Name = "tpConsultar";
            this.tpConsultar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpConsultar.Size = new System.Drawing.Size(888, 431);
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
            this.gboxConsulta.Location = new System.Drawing.Point(43, 115);
            this.gboxConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gboxConsulta.Name = "gboxConsulta";
            this.gboxConsulta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gboxConsulta.Size = new System.Drawing.Size(250, 115);
            this.gboxConsulta.TabIndex = 150;
            this.gboxConsulta.TabStop = false;
            // 
            // rbNombre_Consulta
            // 
            this.rbNombre_Consulta.AutoSize = true;
            this.rbNombre_Consulta.Location = new System.Drawing.Point(110, 69);
            this.rbNombre_Consulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNombre_Consulta.Name = "rbNombre_Consulta";
            this.rbNombre_Consulta.Size = new System.Drawing.Size(97, 17);
            this.rbNombre_Consulta.TabIndex = 149;
            this.rbNombre_Consulta.TabStop = true;
            this.rbNombre_Consulta.Text = "Nombre Cliente";
            this.rbNombre_Consulta.UseVisualStyleBackColor = true;
            this.rbNombre_Consulta.CheckedChanged += new System.EventHandler(this.rbNombre_Consulta_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 147;
            this.label1.Text = "Consultar por:";
            // 
            // rbCodigo_Consulta
            // 
            this.rbCodigo_Consulta.AutoSize = true;
            this.rbCodigo_Consulta.Location = new System.Drawing.Point(110, 35);
            this.rbCodigo_Consulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCodigo_Consulta.Name = "rbCodigo_Consulta";
            this.rbCodigo_Consulta.Size = new System.Drawing.Size(93, 17);
            this.rbCodigo_Consulta.TabIndex = 148;
            this.rbCodigo_Consulta.TabStop = true;
            this.rbCodigo_Consulta.Text = "Codigo Cliente";
            this.rbCodigo_Consulta.UseVisualStyleBackColor = true;
            this.rbCodigo_Consulta.CheckedChanged += new System.EventHandler(this.rbCodigo_Consulta_CheckedChanged);
            // 
            // btnSalir_Consulta
            // 
            this.btnSalir_Consulta.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir_Consulta.Image")));
            this.btnSalir_Consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir_Consulta.Location = new System.Drawing.Point(705, 353);
            this.btnSalir_Consulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir_Consulta.Name = "btnSalir_Consulta";
            this.btnSalir_Consulta.Size = new System.Drawing.Size(117, 29);
            this.btnSalir_Consulta.TabIndex = 146;
            this.btnSalir_Consulta.Text = "Salir";
            this.btnSalir_Consulta.UseVisualStyleBackColor = true;
            this.btnSalir_Consulta.Click += new System.EventHandler(this.btnSalir_Consulta_Click);
            // 
            // btnRegresar_Consulta
            // 
            this.btnRegresar_Consulta.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar_Consulta.Image")));
            this.btnRegresar_Consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar_Consulta.Location = new System.Drawing.Point(568, 353);
            this.btnRegresar_Consulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresar_Consulta.Name = "btnRegresar_Consulta";
            this.btnRegresar_Consulta.Size = new System.Drawing.Size(117, 29);
            this.btnRegresar_Consulta.TabIndex = 145;
            this.btnRegresar_Consulta.Text = "Regresar";
            this.btnRegresar_Consulta.UseVisualStyleBackColor = true;
            this.btnRegresar_Consulta.Click += new System.EventHandler(this.btnRegresar_Consulta_Click);
            // 
            // btnConfirmar_Consulta
            // 
            this.btnConfirmar_Consulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar_Consulta.Image")));
            this.btnConfirmar_Consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar_Consulta.Location = new System.Drawing.Point(428, 353);
            this.btnConfirmar_Consulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmar_Consulta.Name = "btnConfirmar_Consulta";
            this.btnConfirmar_Consulta.Size = new System.Drawing.Size(117, 29);
            this.btnConfirmar_Consulta.TabIndex = 144;
            this.btnConfirmar_Consulta.Text = "Confirmar";
            this.btnConfirmar_Consulta.UseVisualStyleBackColor = true;
            this.btnConfirmar_Consulta.Click += new System.EventHandler(this.btnConfirmar_Consulta_Click);
            // 
            // txtNombre_Consulta
            // 
            this.txtNombre_Consulta.Location = new System.Drawing.Point(166, 324);
            this.txtNombre_Consulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre_Consulta.Name = "txtNombre_Consulta";
            this.txtNombre_Consulta.ReadOnly = true;
            this.txtNombre_Consulta.Size = new System.Drawing.Size(128, 20);
            this.txtNombre_Consulta.TabIndex = 134;
            // 
            // txtCodigo_Consulta
            // 
            this.txtCodigo_Consulta.Location = new System.Drawing.Point(166, 281);
            this.txtCodigo_Consulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo_Consulta.Name = "txtCodigo_Consulta";
            this.txtCodigo_Consulta.ReadOnly = true;
            this.txtCodigo_Consulta.Size = new System.Drawing.Size(128, 20);
            this.txtCodigo_Consulta.TabIndex = 133;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(318, 34);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(219, 38);
            this.label24.TabIndex = 132;
            this.label24.Text = "Consultar Cliente";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(398, 123);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(453, 204);
            this.dgvConsulta.TabIndex = 131;
            // 
            // lblNombre_Consultar
            // 
            this.lblNombre_Consultar.AutoSize = true;
            this.lblNombre_Consultar.Location = new System.Drawing.Point(40, 329);
            this.lblNombre_Consultar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre_Consultar.Name = "lblNombre_Consultar";
            this.lblNombre_Consultar.Size = new System.Drawing.Size(82, 13);
            this.lblNombre_Consultar.TabIndex = 127;
            this.lblNombre_Consultar.Text = "Nombre Cliente:";
            // 
            // lblCodigo_Consultar
            // 
            this.lblCodigo_Consultar.AutoSize = true;
            this.lblCodigo_Consultar.Location = new System.Drawing.Point(40, 286);
            this.lblCodigo_Consultar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo_Consultar.Name = "lblCodigo_Consultar";
            this.lblCodigo_Consultar.Size = new System.Drawing.Size(78, 13);
            this.lblCodigo_Consultar.TabIndex = 126;
            this.lblCodigo_Consultar.Text = "Codigo Cliente:";
            // 
            // Form_ClientesEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 462);
            this.Controls.Add(this.tbcClientes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_ClientesEmpleados";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form_ClientesEmpleados_Load);
            this.tbcClientes.ResumeLayout(false);
            this.tpAgregar.ResumeLayout(false);
            this.tpAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).EndInit();
            this.tpConsultar.ResumeLayout(false);
            this.tpConsultar.PerformLayout();
            this.gboxConsulta.ResumeLayout(false);
            this.gboxConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcClientes;
        private System.Windows.Forms.TabPage tpAgregar;
        private System.Windows.Forms.TextBox txtTelefono_Agregar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento_Agregar;
        private System.Windows.Forms.TextBox txtDireccion_Agregar;
        private System.Windows.Forms.TextBox txtApellido_Agregar;
        private System.Windows.Forms.TextBox txtNombre_Agregar;
        private System.Windows.Forms.Button btnSalir_Agregar;
        private System.Windows.Forms.Button btnRegresar_Agregar;
        private System.Windows.Forms.Button btnConfirmar_Agregar;
        private System.Windows.Forms.DataGridView dgvAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
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