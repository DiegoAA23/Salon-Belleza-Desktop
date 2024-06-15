namespace Proyecto_Final_2
{
    partial class Form_Cliente_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cliente_));
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
            this.tpActualizar = new System.Windows.Forms.TabPage();
            this.txtTelefono_Actualizar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento_Actualizar = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion_Actualizar = new System.Windows.Forms.TextBox();
            this.txtApellido_Actualizar = new System.Windows.Forms.TextBox();
            this.txtNombre_Actualizar = new System.Windows.Forms.TextBox();
            this.txtCodigo_Actualizar = new System.Windows.Forms.TextBox();
            this.btnSalir_Actualizar = new System.Windows.Forms.Button();
            this.btnRegresar_Actualizar = new System.Windows.Forms.Button();
            this.btnConfirmar_Actualizar = new System.Windows.Forms.Button();
            this.dgvActualizar = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tpEliminar = new System.Windows.Forms.TabPage();
            this.btnSalir_Eliminar = new System.Windows.Forms.Button();
            this.btnRegresar_Eliminar = new System.Windows.Forms.Button();
            this.btnConfirmar_Eliminar = new System.Windows.Forms.Button();
            this.txtCodigo_Eliminar = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvEliminar = new System.Windows.Forms.DataGridView();
            this.lblCodigo_Eliminar = new System.Windows.Forms.Label();
            this.tbcClientes.SuspendLayout();
            this.tpAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).BeginInit();
            this.tpConsultar.SuspendLayout();
            this.gboxConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.tpActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizar)).BeginInit();
            this.tpEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcClientes
            // 
            this.tbcClientes.Controls.Add(this.tpAgregar);
            this.tbcClientes.Controls.Add(this.tpConsultar);
            this.tbcClientes.Controls.Add(this.tpActualizar);
            this.tbcClientes.Controls.Add(this.tpEliminar);
            this.tbcClientes.Location = new System.Drawing.Point(-2, 2);
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
            this.txtNombre_Agregar.TextChanged += new System.EventHandler(this.txtNombre_Agregar_TextChanged);
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
            this.tpConsultar.Click += new System.EventHandler(this.tpConsultar_Click);
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
            // tpActualizar
            // 
            this.tpActualizar.Controls.Add(this.txtTelefono_Actualizar);
            this.tpActualizar.Controls.Add(this.label15);
            this.tpActualizar.Controls.Add(this.dtpFechaNacimiento_Actualizar);
            this.tpActualizar.Controls.Add(this.txtDireccion_Actualizar);
            this.tpActualizar.Controls.Add(this.txtApellido_Actualizar);
            this.tpActualizar.Controls.Add(this.txtNombre_Actualizar);
            this.tpActualizar.Controls.Add(this.txtCodigo_Actualizar);
            this.tpActualizar.Controls.Add(this.btnSalir_Actualizar);
            this.tpActualizar.Controls.Add(this.btnRegresar_Actualizar);
            this.tpActualizar.Controls.Add(this.btnConfirmar_Actualizar);
            this.tpActualizar.Controls.Add(this.dgvActualizar);
            this.tpActualizar.Controls.Add(this.label8);
            this.tpActualizar.Controls.Add(this.label9);
            this.tpActualizar.Controls.Add(this.label10);
            this.tpActualizar.Controls.Add(this.label11);
            this.tpActualizar.Controls.Add(this.label12);
            this.tpActualizar.Controls.Add(this.label14);
            this.tpActualizar.Location = new System.Drawing.Point(4, 22);
            this.tpActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpActualizar.Name = "tpActualizar";
            this.tpActualizar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpActualizar.Size = new System.Drawing.Size(888, 431);
            this.tpActualizar.TabIndex = 2;
            this.tpActualizar.Text = "Actualizar";
            this.tpActualizar.UseVisualStyleBackColor = true;
            // 
            // txtTelefono_Actualizar
            // 
            this.txtTelefono_Actualizar.Location = new System.Drawing.Point(163, 358);
            this.txtTelefono_Actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono_Actualizar.Name = "txtTelefono_Actualizar";
            this.txtTelefono_Actualizar.Size = new System.Drawing.Size(128, 20);
            this.txtTelefono_Actualizar.TabIndex = 125;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 363);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 124;
            this.label15.Text = "Teléfono:";
            // 
            // dtpFechaNacimiento_Actualizar
            // 
            this.dtpFechaNacimiento_Actualizar.Location = new System.Drawing.Point(163, 313);
            this.dtpFechaNacimiento_Actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaNacimiento_Actualizar.Name = "dtpFechaNacimiento_Actualizar";
            this.dtpFechaNacimiento_Actualizar.Size = new System.Drawing.Size(197, 20);
            this.dtpFechaNacimiento_Actualizar.TabIndex = 123;
            // 
            // txtDireccion_Actualizar
            // 
            this.txtDireccion_Actualizar.Location = new System.Drawing.Point(163, 266);
            this.txtDireccion_Actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion_Actualizar.Name = "txtDireccion_Actualizar";
            this.txtDireccion_Actualizar.Size = new System.Drawing.Size(128, 20);
            this.txtDireccion_Actualizar.TabIndex = 122;
            // 
            // txtApellido_Actualizar
            // 
            this.txtApellido_Actualizar.Location = new System.Drawing.Point(163, 219);
            this.txtApellido_Actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido_Actualizar.Name = "txtApellido_Actualizar";
            this.txtApellido_Actualizar.Size = new System.Drawing.Size(128, 20);
            this.txtApellido_Actualizar.TabIndex = 121;
            // 
            // txtNombre_Actualizar
            // 
            this.txtNombre_Actualizar.Location = new System.Drawing.Point(163, 176);
            this.txtNombre_Actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre_Actualizar.Name = "txtNombre_Actualizar";
            this.txtNombre_Actualizar.Size = new System.Drawing.Size(128, 20);
            this.txtNombre_Actualizar.TabIndex = 120;
            // 
            // txtCodigo_Actualizar
            // 
            this.txtCodigo_Actualizar.Location = new System.Drawing.Point(163, 132);
            this.txtCodigo_Actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo_Actualizar.Name = "txtCodigo_Actualizar";
            this.txtCodigo_Actualizar.Size = new System.Drawing.Size(128, 20);
            this.txtCodigo_Actualizar.TabIndex = 119;
            // 
            // btnSalir_Actualizar
            // 
            this.btnSalir_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir_Actualizar.Image")));
            this.btnSalir_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir_Actualizar.Location = new System.Drawing.Point(711, 353);
            this.btnSalir_Actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir_Actualizar.Name = "btnSalir_Actualizar";
            this.btnSalir_Actualizar.Size = new System.Drawing.Size(117, 29);
            this.btnSalir_Actualizar.TabIndex = 118;
            this.btnSalir_Actualizar.Text = "Salir";
            this.btnSalir_Actualizar.UseVisualStyleBackColor = true;
            this.btnSalir_Actualizar.Click += new System.EventHandler(this.btnSalir_Actualizar_Click);
            // 
            // btnRegresar_Actualizar
            // 
            this.btnRegresar_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar_Actualizar.Image")));
            this.btnRegresar_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar_Actualizar.Location = new System.Drawing.Point(574, 353);
            this.btnRegresar_Actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresar_Actualizar.Name = "btnRegresar_Actualizar";
            this.btnRegresar_Actualizar.Size = new System.Drawing.Size(117, 29);
            this.btnRegresar_Actualizar.TabIndex = 117;
            this.btnRegresar_Actualizar.Text = "Regresar";
            this.btnRegresar_Actualizar.UseVisualStyleBackColor = true;
            this.btnRegresar_Actualizar.Click += new System.EventHandler(this.btnRegresar_Actualizar_Click);
            // 
            // btnConfirmar_Actualizar
            // 
            this.btnConfirmar_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar_Actualizar.Image")));
            this.btnConfirmar_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar_Actualizar.Location = new System.Drawing.Point(434, 353);
            this.btnConfirmar_Actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmar_Actualizar.Name = "btnConfirmar_Actualizar";
            this.btnConfirmar_Actualizar.Size = new System.Drawing.Size(117, 29);
            this.btnConfirmar_Actualizar.TabIndex = 116;
            this.btnConfirmar_Actualizar.Text = "Confirmar";
            this.btnConfirmar_Actualizar.UseVisualStyleBackColor = true;
            this.btnConfirmar_Actualizar.Click += new System.EventHandler(this.btnConfirmar_Actualizar_Click);
            // 
            // dgvActualizar
            // 
            this.dgvActualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizar.Location = new System.Drawing.Point(399, 124);
            this.dgvActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvActualizar.Name = "dgvActualizar";
            this.dgvActualizar.RowHeadersWidth = 51;
            this.dgvActualizar.RowTemplate.Height = 24;
            this.dgvActualizar.Size = new System.Drawing.Size(453, 204);
            this.dgvActualizar.TabIndex = 115;
            this.dgvActualizar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActualizar_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 114;
            this.label8.Text = "Dirección Cliente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 317);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 113;
            this.label9.Text = "Fecha de Nacimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 224);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 112;
            this.label10.Text = "Apellido Cliente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 180);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 111;
            this.label11.Text = "Nombre Cliente:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 137);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 110;
            this.label12.Text = "Codigo Cliente:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(318, 32);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(225, 38);
            this.label14.TabIndex = 109;
            this.label14.Text = "Actualizar Cliente";
            // 
            // tpEliminar
            // 
            this.tpEliminar.Controls.Add(this.btnSalir_Eliminar);
            this.tpEliminar.Controls.Add(this.btnRegresar_Eliminar);
            this.tpEliminar.Controls.Add(this.btnConfirmar_Eliminar);
            this.tpEliminar.Controls.Add(this.txtCodigo_Eliminar);
            this.tpEliminar.Controls.Add(this.label21);
            this.tpEliminar.Controls.Add(this.dgvEliminar);
            this.tpEliminar.Controls.Add(this.lblCodigo_Eliminar);
            this.tpEliminar.Location = new System.Drawing.Point(4, 22);
            this.tpEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpEliminar.Name = "tpEliminar";
            this.tpEliminar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpEliminar.Size = new System.Drawing.Size(888, 431);
            this.tpEliminar.TabIndex = 3;
            this.tpEliminar.Text = "Eliminar";
            this.tpEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir_Eliminar
            // 
            this.btnSalir_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir_Eliminar.Image")));
            this.btnSalir_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir_Eliminar.Location = new System.Drawing.Point(705, 354);
            this.btnSalir_Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir_Eliminar.Name = "btnSalir_Eliminar";
            this.btnSalir_Eliminar.Size = new System.Drawing.Size(117, 29);
            this.btnSalir_Eliminar.TabIndex = 159;
            this.btnSalir_Eliminar.Text = "Salir";
            this.btnSalir_Eliminar.UseVisualStyleBackColor = true;
            this.btnSalir_Eliminar.Click += new System.EventHandler(this.btnSalir_Eliminar_Click);
            // 
            // btnRegresar_Eliminar
            // 
            this.btnRegresar_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar_Eliminar.Image")));
            this.btnRegresar_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar_Eliminar.Location = new System.Drawing.Point(568, 354);
            this.btnRegresar_Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresar_Eliminar.Name = "btnRegresar_Eliminar";
            this.btnRegresar_Eliminar.Size = new System.Drawing.Size(117, 29);
            this.btnRegresar_Eliminar.TabIndex = 158;
            this.btnRegresar_Eliminar.Text = "Regresar";
            this.btnRegresar_Eliminar.UseVisualStyleBackColor = true;
            this.btnRegresar_Eliminar.Click += new System.EventHandler(this.btnRegresar_Eliminar_Click);
            // 
            // btnConfirmar_Eliminar
            // 
            this.btnConfirmar_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar_Eliminar.Image")));
            this.btnConfirmar_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar_Eliminar.Location = new System.Drawing.Point(428, 354);
            this.btnConfirmar_Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmar_Eliminar.Name = "btnConfirmar_Eliminar";
            this.btnConfirmar_Eliminar.Size = new System.Drawing.Size(117, 29);
            this.btnConfirmar_Eliminar.TabIndex = 157;
            this.btnConfirmar_Eliminar.Text = "Confirmar";
            this.btnConfirmar_Eliminar.UseVisualStyleBackColor = true;
            this.btnConfirmar_Eliminar.Click += new System.EventHandler(this.btnConfirmar_Eliminar_Click);
            // 
            // txtCodigo_Eliminar
            // 
            this.txtCodigo_Eliminar.Location = new System.Drawing.Point(166, 221);
            this.txtCodigo_Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo_Eliminar.Name = "txtCodigo_Eliminar";
            this.txtCodigo_Eliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigo_Eliminar.Size = new System.Drawing.Size(128, 20);
            this.txtCodigo_Eliminar.TabIndex = 155;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(318, 26);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(212, 38);
            this.label21.TabIndex = 154;
            this.label21.Text = "Eliminar Cliente";
            // 
            // dgvEliminar
            // 
            this.dgvEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminar.Location = new System.Drawing.Point(398, 117);
            this.dgvEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEliminar.Name = "dgvEliminar";
            this.dgvEliminar.RowHeadersWidth = 51;
            this.dgvEliminar.RowTemplate.Height = 24;
            this.dgvEliminar.Size = new System.Drawing.Size(453, 204);
            this.dgvEliminar.TabIndex = 153;
            this.dgvEliminar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEliminar_CellClick);
            // 
            // lblCodigo_Eliminar
            // 
            this.lblCodigo_Eliminar.AutoSize = true;
            this.lblCodigo_Eliminar.Location = new System.Drawing.Point(40, 226);
            this.lblCodigo_Eliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo_Eliminar.Name = "lblCodigo_Eliminar";
            this.lblCodigo_Eliminar.Size = new System.Drawing.Size(78, 13);
            this.lblCodigo_Eliminar.TabIndex = 151;
            this.lblCodigo_Eliminar.Text = "Codigo Cliente:";
            // 
            // Form_Cliente_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 453);
            this.Controls.Add(this.tbcClientes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Cliente_";
            this.Text = "Form_Cliente_";
            this.Load += new System.EventHandler(this.Form_Cliente__Load);
            this.tbcClientes.ResumeLayout(false);
            this.tpAgregar.ResumeLayout(false);
            this.tpAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).EndInit();
            this.tpConsultar.ResumeLayout(false);
            this.tpConsultar.PerformLayout();
            this.gboxConsulta.ResumeLayout(false);
            this.gboxConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.tpActualizar.ResumeLayout(false);
            this.tpActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActualizar)).EndInit();
            this.tpEliminar.ResumeLayout(false);
            this.tpEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).EndInit();
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
        private System.Windows.Forms.TabPage tpActualizar;
        private System.Windows.Forms.TextBox txtTelefono_Actualizar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento_Actualizar;
        private System.Windows.Forms.TextBox txtDireccion_Actualizar;
        private System.Windows.Forms.TextBox txtApellido_Actualizar;
        private System.Windows.Forms.TextBox txtNombre_Actualizar;
        private System.Windows.Forms.TextBox txtCodigo_Actualizar;
        private System.Windows.Forms.Button btnSalir_Actualizar;
        private System.Windows.Forms.Button btnRegresar_Actualizar;
        private System.Windows.Forms.Button btnConfirmar_Actualizar;
        private System.Windows.Forms.DataGridView dgvActualizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tpEliminar;
        private System.Windows.Forms.Button btnSalir_Eliminar;
        private System.Windows.Forms.Button btnRegresar_Eliminar;
        private System.Windows.Forms.Button btnConfirmar_Eliminar;
        private System.Windows.Forms.TextBox txtCodigo_Eliminar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvEliminar;
        private System.Windows.Forms.Label lblCodigo_Eliminar;
    }
}