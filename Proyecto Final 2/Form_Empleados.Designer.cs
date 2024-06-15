namespace Proyecto_Final_2
{
    partial class Form_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Empleados));
            this.tbcEmpleados = new System.Windows.Forms.TabControl();
            this.tpAgregar = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtCorreo_Agregar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono_Agregar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento_Agregar = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion_Agregar = new System.Windows.Forms.TextBox();
            this.txtApellido_Agregar = new System.Windows.Forms.TextBox();
            this.txtNombre_Agregar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAgregar = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnSalir_Actualizar = new System.Windows.Forms.Button();
            this.btnRegresar_Actualizar = new System.Windows.Forms.Button();
            this.btnConfirmar_Actualizar = new System.Windows.Forms.Button();
            this.txtCorreo_Actualizar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefono_Actualizar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento_Actualizar = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion_Actualizar = new System.Windows.Forms.TextBox();
            this.txtApellido_Actualizar = new System.Windows.Forms.TextBox();
            this.txtNombre_Actualizar = new System.Windows.Forms.TextBox();
            this.txtCodigo_Actualizar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvActualizar = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tpEliminar = new System.Windows.Forms.TabPage();
            this.btnSalir_Eliminar = new System.Windows.Forms.Button();
            this.btnRegresar_Eliminar = new System.Windows.Forms.Button();
            this.btnConfirmar_Eliminar = new System.Windows.Forms.Button();
            this.txtCodigo_Eliminar = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvEliminar = new System.Windows.Forms.DataGridView();
            this.lblCodigo_Eliminar = new System.Windows.Forms.Label();
            this.tbcEmpleados.SuspendLayout();
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
            // tbcEmpleados
            // 
            this.tbcEmpleados.Controls.Add(this.tpAgregar);
            this.tbcEmpleados.Controls.Add(this.tpConsultar);
            this.tbcEmpleados.Controls.Add(this.tpActualizar);
            this.tbcEmpleados.Controls.Add(this.tpEliminar);
            this.tbcEmpleados.Location = new System.Drawing.Point(0, 0);
            this.tbcEmpleados.Name = "tbcEmpleados";
            this.tbcEmpleados.SelectedIndex = 0;
            this.tbcEmpleados.Size = new System.Drawing.Size(1196, 663);
            this.tbcEmpleados.TabIndex = 0;
            this.tbcEmpleados.SelectedIndexChanged += new System.EventHandler(this.tbcEmpleados_SelectedIndexChanged);
            // 
            // tpAgregar
            // 
            this.tpAgregar.Controls.Add(this.comboBox1);
            this.tpAgregar.Controls.Add(this.btnSalir);
            this.tpAgregar.Controls.Add(this.btnRegresar);
            this.tpAgregar.Controls.Add(this.btnConfirmar);
            this.tpAgregar.Controls.Add(this.txtCorreo_Agregar);
            this.tpAgregar.Controls.Add(this.label9);
            this.tpAgregar.Controls.Add(this.txtTelefono_Agregar);
            this.tpAgregar.Controls.Add(this.label10);
            this.tpAgregar.Controls.Add(this.label8);
            this.tpAgregar.Controls.Add(this.dtpFechaNacimiento_Agregar);
            this.tpAgregar.Controls.Add(this.txtDireccion_Agregar);
            this.tpAgregar.Controls.Add(this.txtApellido_Agregar);
            this.tpAgregar.Controls.Add(this.txtNombre_Agregar);
            this.tpAgregar.Controls.Add(this.label7);
            this.tpAgregar.Controls.Add(this.dgvAgregar);
            this.tpAgregar.Controls.Add(this.label6);
            this.tpAgregar.Controls.Add(this.label5);
            this.tpAgregar.Controls.Add(this.label4);
            this.tpAgregar.Controls.Add(this.label3);
            this.tpAgregar.Location = new System.Drawing.Point(4, 25);
            this.tpAgregar.Name = "tpAgregar";
            this.tpAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAgregar.Size = new System.Drawing.Size(1188, 634);
            this.tpAgregar.TabIndex = 0;
            this.tpAgregar.Text = "Agregar";
            this.tpAgregar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(203, 305);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 24);
            this.comboBox1.TabIndex = 101;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(922, 460);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(156, 36);
            this.btnSalir.TabIndex = 100;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(739, 460);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(156, 36);
            this.btnRegresar.TabIndex = 99;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(553, 460);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(156, 36);
            this.btnConfirmar.TabIndex = 98;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtCorreo_Agregar
            // 
            this.txtCorreo_Agregar.Location = new System.Drawing.Point(203, 485);
            this.txtCorreo_Agregar.Name = "txtCorreo_Agregar";
            this.txtCorreo_Agregar.Size = new System.Drawing.Size(170, 22);
            this.txtCorreo_Agregar.TabIndex = 97;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 96;
            this.label9.Text = "Correo Empleado:";
            // 
            // txtTelefono_Agregar
            // 
            this.txtTelefono_Agregar.Location = new System.Drawing.Point(203, 428);
            this.txtTelefono_Agregar.Name = "txtTelefono_Agregar";
            this.txtTelefono_Agregar.Size = new System.Drawing.Size(170, 22);
            this.txtTelefono_Agregar.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 94;
            this.label10.Text = "Teléfono Empleado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 92;
            this.label8.Text = "Puesto Empleado:";
            // 
            // dtpFechaNacimiento_Agregar
            // 
            this.dtpFechaNacimiento_Agregar.Checked = false;
            this.dtpFechaNacimiento_Agregar.Location = new System.Drawing.Point(203, 368);
            this.dtpFechaNacimiento_Agregar.Name = "dtpFechaNacimiento_Agregar";
            this.dtpFechaNacimiento_Agregar.Size = new System.Drawing.Size(261, 22);
            this.dtpFechaNacimiento_Agregar.TabIndex = 91;
            // 
            // txtDireccion_Agregar
            // 
            this.txtDireccion_Agregar.Location = new System.Drawing.Point(203, 248);
            this.txtDireccion_Agregar.Name = "txtDireccion_Agregar";
            this.txtDireccion_Agregar.Size = new System.Drawing.Size(170, 22);
            this.txtDireccion_Agregar.TabIndex = 90;
            // 
            // txtApellido_Agregar
            // 
            this.txtApellido_Agregar.Location = new System.Drawing.Point(203, 190);
            this.txtApellido_Agregar.Name = "txtApellido_Agregar";
            this.txtApellido_Agregar.Size = new System.Drawing.Size(170, 22);
            this.txtApellido_Agregar.TabIndex = 89;
            // 
            // txtNombre_Agregar
            // 
            this.txtNombre_Agregar.Location = new System.Drawing.Point(203, 136);
            this.txtNombre_Agregar.Name = "txtNombre_Agregar";
            this.txtNombre_Agregar.Size = new System.Drawing.Size(170, 22);
            this.txtNombre_Agregar.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(455, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 48);
            this.label7.TabIndex = 86;
            this.label7.Text = "Agregar Empleado";
            // 
            // dgvAgregar
            // 
            this.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregar.Location = new System.Drawing.Point(513, 176);
            this.dgvAgregar.Name = "dgvAgregar";
            this.dgvAgregar.RowHeadersWidth = 51;
            this.dgvAgregar.RowTemplate.Height = 24;
            this.dgvAgregar.Size = new System.Drawing.Size(604, 251);
            this.dgvAgregar.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 84;
            this.label6.Text = "Dirección Empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 83;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 82;
            this.label4.Text = "Apellido Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 81;
            this.label3.Text = "Nombre Empleado:";
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
            this.tpConsultar.Size = new System.Drawing.Size(1188, 634);
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
            this.gboxConsulta.Location = new System.Drawing.Point(57, 190);
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
            this.rbNombre_Consulta.Size = new System.Drawing.Size(165, 20);
            this.rbNombre_Consulta.TabIndex = 149;
            this.rbNombre_Consulta.TabStop = true;
            this.rbNombre_Consulta.Text = "Nombre del Empleado";
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
            this.rbCodigo_Consulta.Size = new System.Drawing.Size(157, 20);
            this.rbCodigo_Consulta.TabIndex = 148;
            this.rbCodigo_Consulta.TabStop = true;
            this.rbCodigo_Consulta.Text = "Codigo de Empleado";
            this.rbCodigo_Consulta.UseVisualStyleBackColor = true;
            this.rbCodigo_Consulta.CheckedChanged += new System.EventHandler(this.rbCodigo_Consulta_CheckedChanged);
            // 
            // btnSalir_Consulta
            // 
            this.btnSalir_Consulta.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir_Consulta.Image")));
            this.btnSalir_Consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir_Consulta.Location = new System.Drawing.Point(940, 484);
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
            this.btnRegresar_Consulta.Location = new System.Drawing.Point(757, 484);
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
            this.btnConfirmar_Consulta.Location = new System.Drawing.Point(571, 484);
            this.btnConfirmar_Consulta.Name = "btnConfirmar_Consulta";
            this.btnConfirmar_Consulta.Size = new System.Drawing.Size(156, 36);
            this.btnConfirmar_Consulta.TabIndex = 144;
            this.btnConfirmar_Consulta.Text = "Confirmar";
            this.btnConfirmar_Consulta.UseVisualStyleBackColor = true;
            this.btnConfirmar_Consulta.Click += new System.EventHandler(this.btnConfirmar_Consulta_Click);
            // 
            // txtNombre_Consulta
            // 
            this.txtNombre_Consulta.Location = new System.Drawing.Point(221, 448);
            this.txtNombre_Consulta.Name = "txtNombre_Consulta";
            this.txtNombre_Consulta.ReadOnly = true;
            this.txtNombre_Consulta.Size = new System.Drawing.Size(170, 22);
            this.txtNombre_Consulta.TabIndex = 134;
            // 
            // txtCodigo_Consulta
            // 
            this.txtCodigo_Consulta.Location = new System.Drawing.Point(221, 395);
            this.txtCodigo_Consulta.Name = "txtCodigo_Consulta";
            this.txtCodigo_Consulta.ReadOnly = true;
            this.txtCodigo_Consulta.Size = new System.Drawing.Size(170, 22);
            this.txtCodigo_Consulta.TabIndex = 133;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(424, 53);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(300, 48);
            this.label24.TabIndex = 132;
            this.label24.Text = "Consultar Empleado";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(531, 200);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(604, 251);
            this.dgvConsulta.TabIndex = 131;
            // 
            // lblNombre_Consultar
            // 
            this.lblNombre_Consultar.AutoSize = true;
            this.lblNombre_Consultar.Location = new System.Drawing.Point(54, 454);
            this.lblNombre_Consultar.Name = "lblNombre_Consultar";
            this.lblNombre_Consultar.Size = new System.Drawing.Size(125, 16);
            this.lblNombre_Consultar.TabIndex = 127;
            this.lblNombre_Consultar.Text = "Nombre Empleado:";
            // 
            // lblCodigo_Consultar
            // 
            this.lblCodigo_Consultar.AutoSize = true;
            this.lblCodigo_Consultar.Location = new System.Drawing.Point(54, 401);
            this.lblCodigo_Consultar.Name = "lblCodigo_Consultar";
            this.lblCodigo_Consultar.Size = new System.Drawing.Size(120, 16);
            this.lblCodigo_Consultar.TabIndex = 126;
            this.lblCodigo_Consultar.Text = "Codigo Empleado:";
            // 
            // tpActualizar
            // 
            this.tpActualizar.Controls.Add(this.comboBox2);
            this.tpActualizar.Controls.Add(this.btnSalir_Actualizar);
            this.tpActualizar.Controls.Add(this.btnRegresar_Actualizar);
            this.tpActualizar.Controls.Add(this.btnConfirmar_Actualizar);
            this.tpActualizar.Controls.Add(this.txtCorreo_Actualizar);
            this.tpActualizar.Controls.Add(this.label11);
            this.tpActualizar.Controls.Add(this.txtTelefono_Actualizar);
            this.tpActualizar.Controls.Add(this.label12);
            this.tpActualizar.Controls.Add(this.label13);
            this.tpActualizar.Controls.Add(this.dtpFechaNacimiento_Actualizar);
            this.tpActualizar.Controls.Add(this.txtDireccion_Actualizar);
            this.tpActualizar.Controls.Add(this.txtApellido_Actualizar);
            this.tpActualizar.Controls.Add(this.txtNombre_Actualizar);
            this.tpActualizar.Controls.Add(this.txtCodigo_Actualizar);
            this.tpActualizar.Controls.Add(this.label14);
            this.tpActualizar.Controls.Add(this.dgvActualizar);
            this.tpActualizar.Controls.Add(this.label15);
            this.tpActualizar.Controls.Add(this.label16);
            this.tpActualizar.Controls.Add(this.label17);
            this.tpActualizar.Controls.Add(this.label18);
            this.tpActualizar.Controls.Add(this.label19);
            this.tpActualizar.Location = new System.Drawing.Point(4, 25);
            this.tpActualizar.Name = "tpActualizar";
            this.tpActualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tpActualizar.Size = new System.Drawing.Size(1188, 634);
            this.tpActualizar.TabIndex = 2;
            this.tpActualizar.Text = "Actualizar";
            this.tpActualizar.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Administrador",
            "Estilista",
            "Cajero",
            "Manicurista"});
            this.comboBox2.Location = new System.Drawing.Point(221, 357);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(170, 24);
            this.comboBox2.TabIndex = 124;
            // 
            // btnSalir_Actualizar
            // 
            this.btnSalir_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir_Actualizar.Image")));
            this.btnSalir_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir_Actualizar.Location = new System.Drawing.Point(940, 462);
            this.btnSalir_Actualizar.Name = "btnSalir_Actualizar";
            this.btnSalir_Actualizar.Size = new System.Drawing.Size(156, 36);
            this.btnSalir_Actualizar.TabIndex = 123;
            this.btnSalir_Actualizar.Text = "Salir";
            this.btnSalir_Actualizar.UseVisualStyleBackColor = true;
            this.btnSalir_Actualizar.Click += new System.EventHandler(this.btnSalir_Actualizar_Click);
            // 
            // btnRegresar_Actualizar
            // 
            this.btnRegresar_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar_Actualizar.Image")));
            this.btnRegresar_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar_Actualizar.Location = new System.Drawing.Point(757, 462);
            this.btnRegresar_Actualizar.Name = "btnRegresar_Actualizar";
            this.btnRegresar_Actualizar.Size = new System.Drawing.Size(156, 36);
            this.btnRegresar_Actualizar.TabIndex = 122;
            this.btnRegresar_Actualizar.Text = "Regresar";
            this.btnRegresar_Actualizar.UseVisualStyleBackColor = true;
            this.btnRegresar_Actualizar.Click += new System.EventHandler(this.btnRegresar_Actualizar_Click);
            // 
            // btnConfirmar_Actualizar
            // 
            this.btnConfirmar_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar_Actualizar.Image")));
            this.btnConfirmar_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar_Actualizar.Location = new System.Drawing.Point(571, 462);
            this.btnConfirmar_Actualizar.Name = "btnConfirmar_Actualizar";
            this.btnConfirmar_Actualizar.Size = new System.Drawing.Size(156, 36);
            this.btnConfirmar_Actualizar.TabIndex = 121;
            this.btnConfirmar_Actualizar.Text = "Confirmar";
            this.btnConfirmar_Actualizar.UseVisualStyleBackColor = true;
            this.btnConfirmar_Actualizar.Click += new System.EventHandler(this.btnConfirmar_Actualizar_Click);
            // 
            // txtCorreo_Actualizar
            // 
            this.txtCorreo_Actualizar.Location = new System.Drawing.Point(221, 539);
            this.txtCorreo_Actualizar.Name = "txtCorreo_Actualizar";
            this.txtCorreo_Actualizar.Size = new System.Drawing.Size(170, 22);
            this.txtCorreo_Actualizar.TabIndex = 120;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 545);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 16);
            this.label11.TabIndex = 119;
            this.label11.Text = "Correo Empleado:";
            // 
            // txtTelefono_Actualizar
            // 
            this.txtTelefono_Actualizar.Location = new System.Drawing.Point(221, 481);
            this.txtTelefono_Actualizar.Name = "txtTelefono_Actualizar";
            this.txtTelefono_Actualizar.Size = new System.Drawing.Size(170, 22);
            this.txtTelefono_Actualizar.TabIndex = 118;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 487);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 16);
            this.label12.TabIndex = 117;
            this.label12.Text = "Teléfono Empleado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 364);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 16);
            this.label13.TabIndex = 115;
            this.label13.Text = "Puesto Empleado:";
            // 
            // dtpFechaNacimiento_Actualizar
            // 
            this.dtpFechaNacimiento_Actualizar.Checked = false;
            this.dtpFechaNacimiento_Actualizar.Location = new System.Drawing.Point(221, 421);
            this.dtpFechaNacimiento_Actualizar.Name = "dtpFechaNacimiento_Actualizar";
            this.dtpFechaNacimiento_Actualizar.Size = new System.Drawing.Size(261, 22);
            this.dtpFechaNacimiento_Actualizar.TabIndex = 114;
            // 
            // txtDireccion_Actualizar
            // 
            this.txtDireccion_Actualizar.Location = new System.Drawing.Point(221, 301);
            this.txtDireccion_Actualizar.Name = "txtDireccion_Actualizar";
            this.txtDireccion_Actualizar.Size = new System.Drawing.Size(170, 22);
            this.txtDireccion_Actualizar.TabIndex = 113;
            // 
            // txtApellido_Actualizar
            // 
            this.txtApellido_Actualizar.Location = new System.Drawing.Point(221, 243);
            this.txtApellido_Actualizar.Name = "txtApellido_Actualizar";
            this.txtApellido_Actualizar.Size = new System.Drawing.Size(170, 22);
            this.txtApellido_Actualizar.TabIndex = 112;
            // 
            // txtNombre_Actualizar
            // 
            this.txtNombre_Actualizar.Location = new System.Drawing.Point(221, 189);
            this.txtNombre_Actualizar.Name = "txtNombre_Actualizar";
            this.txtNombre_Actualizar.Size = new System.Drawing.Size(170, 22);
            this.txtNombre_Actualizar.TabIndex = 111;
            // 
            // txtCodigo_Actualizar
            // 
            this.txtCodigo_Actualizar.Location = new System.Drawing.Point(221, 136);
            this.txtCodigo_Actualizar.Name = "txtCodigo_Actualizar";
            this.txtCodigo_Actualizar.Size = new System.Drawing.Size(170, 22);
            this.txtCodigo_Actualizar.TabIndex = 110;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(424, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(306, 48);
            this.label14.TabIndex = 109;
            this.label14.Text = "Actualizar Empleado";
            // 
            // dgvActualizar
            // 
            this.dgvActualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizar.Location = new System.Drawing.Point(531, 178);
            this.dgvActualizar.Name = "dgvActualizar";
            this.dgvActualizar.RowHeadersWidth = 51;
            this.dgvActualizar.RowTemplate.Height = 24;
            this.dgvActualizar.Size = new System.Drawing.Size(604, 251);
            this.dgvActualizar.TabIndex = 108;
            this.dgvActualizar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActualizar_CellClick);
            this.dgvActualizar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActualizar_CellContentClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 307);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 16);
            this.label15.TabIndex = 107;
            this.label15.Text = "Dirección Empleado:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(54, 426);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 16);
            this.label16.TabIndex = 106;
            this.label16.Text = "Fecha de Nacimiento:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(54, 249);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 16);
            this.label17.TabIndex = 105;
            this.label17.Text = "Apellido Empleado:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 16);
            this.label18.TabIndex = 104;
            this.label18.Text = "Nombre Empleado:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(54, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 16);
            this.label19.TabIndex = 103;
            this.label19.Text = "Codigo Empleado:";
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
            this.tpEliminar.Location = new System.Drawing.Point(4, 25);
            this.tpEliminar.Name = "tpEliminar";
            this.tpEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tpEliminar.Size = new System.Drawing.Size(1188, 634);
            this.tpEliminar.TabIndex = 3;
            this.tpEliminar.Text = "Eliminar";
            this.tpEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir_Eliminar
            // 
            this.btnSalir_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir_Eliminar.Image")));
            this.btnSalir_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir_Eliminar.Location = new System.Drawing.Point(940, 490);
            this.btnSalir_Eliminar.Name = "btnSalir_Eliminar";
            this.btnSalir_Eliminar.Size = new System.Drawing.Size(156, 36);
            this.btnSalir_Eliminar.TabIndex = 159;
            this.btnSalir_Eliminar.Text = "Salir";
            this.btnSalir_Eliminar.UseVisualStyleBackColor = true;
            this.btnSalir_Eliminar.Click += new System.EventHandler(this.btnSalir_Eliminar_Click);
            // 
            // btnRegresar_Eliminar
            // 
            this.btnRegresar_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar_Eliminar.Image")));
            this.btnRegresar_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar_Eliminar.Location = new System.Drawing.Point(757, 490);
            this.btnRegresar_Eliminar.Name = "btnRegresar_Eliminar";
            this.btnRegresar_Eliminar.Size = new System.Drawing.Size(156, 36);
            this.btnRegresar_Eliminar.TabIndex = 158;
            this.btnRegresar_Eliminar.Text = "Regresar";
            this.btnRegresar_Eliminar.UseVisualStyleBackColor = true;
            this.btnRegresar_Eliminar.Click += new System.EventHandler(this.btnRegresar_Eliminar_Click);
            // 
            // btnConfirmar_Eliminar
            // 
            this.btnConfirmar_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar_Eliminar.Image")));
            this.btnConfirmar_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar_Eliminar.Location = new System.Drawing.Point(571, 490);
            this.btnConfirmar_Eliminar.Name = "btnConfirmar_Eliminar";
            this.btnConfirmar_Eliminar.Size = new System.Drawing.Size(156, 36);
            this.btnConfirmar_Eliminar.TabIndex = 157;
            this.btnConfirmar_Eliminar.Text = "Confirmar";
            this.btnConfirmar_Eliminar.UseVisualStyleBackColor = true;
            this.btnConfirmar_Eliminar.Click += new System.EventHandler(this.btnConfirmar_Eliminar_Click);
            // 
            // txtCodigo_Eliminar
            // 
            this.txtCodigo_Eliminar.Location = new System.Drawing.Point(221, 321);
            this.txtCodigo_Eliminar.Name = "txtCodigo_Eliminar";
            this.txtCodigo_Eliminar.Size = new System.Drawing.Size(170, 22);
            this.txtCodigo_Eliminar.TabIndex = 155;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(424, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(291, 48);
            this.label21.TabIndex = 154;
            this.label21.Text = "Eliminar Empleado";
            // 
            // dgvEliminar
            // 
            this.dgvEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminar.Location = new System.Drawing.Point(531, 198);
            this.dgvEliminar.Name = "dgvEliminar";
            this.dgvEliminar.RowHeadersWidth = 51;
            this.dgvEliminar.RowTemplate.Height = 24;
            this.dgvEliminar.Size = new System.Drawing.Size(604, 251);
            this.dgvEliminar.TabIndex = 153;
            this.dgvEliminar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEliminar_CellClick);
            this.dgvEliminar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEliminar_CellContentClick);
            // 
            // lblCodigo_Eliminar
            // 
            this.lblCodigo_Eliminar.AutoSize = true;
            this.lblCodigo_Eliminar.Location = new System.Drawing.Point(54, 327);
            this.lblCodigo_Eliminar.Name = "lblCodigo_Eliminar";
            this.lblCodigo_Eliminar.Size = new System.Drawing.Size(120, 16);
            this.lblCodigo_Eliminar.TabIndex = 151;
            this.lblCodigo_Eliminar.Text = "Codigo Empleado:";
            // 
            // Form_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 656);
            this.Controls.Add(this.tbcEmpleados);
            this.Name = "Form_Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Form_Empleados_Load);
            this.tbcEmpleados.ResumeLayout(false);
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

        private System.Windows.Forms.TabControl tbcEmpleados;
        private System.Windows.Forms.TabPage tpAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtCorreo_Agregar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefono_Agregar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento_Agregar;
        private System.Windows.Forms.TextBox txtDireccion_Agregar;
        private System.Windows.Forms.TextBox txtApellido_Agregar;
        private System.Windows.Forms.TextBox txtNombre_Agregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Button btnSalir_Actualizar;
        private System.Windows.Forms.Button btnRegresar_Actualizar;
        private System.Windows.Forms.Button btnConfirmar_Actualizar;
        private System.Windows.Forms.TextBox txtCorreo_Actualizar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTelefono_Actualizar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento_Actualizar;
        private System.Windows.Forms.TextBox txtDireccion_Actualizar;
        private System.Windows.Forms.TextBox txtApellido_Actualizar;
        private System.Windows.Forms.TextBox txtNombre_Actualizar;
        private System.Windows.Forms.TextBox txtCodigo_Actualizar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvActualizar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tpEliminar;
        private System.Windows.Forms.Button btnSalir_Eliminar;
        private System.Windows.Forms.Button btnRegresar_Eliminar;
        private System.Windows.Forms.Button btnConfirmar_Eliminar;
        private System.Windows.Forms.TextBox txtCodigo_Eliminar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblCodigo_Eliminar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dgvEliminar;
    }
}