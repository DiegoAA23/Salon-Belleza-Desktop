namespace Proyecto_Final_2
{
    partial class Form_Servicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Servicios));
            this.tbcServicios = new System.Windows.Forms.TabControl();
            this.tpAgregar = new System.Windows.Forms.TabPage();
            this.btnSalir_Agregar = new System.Windows.Forms.Button();
            this.btnRegresar_Agregar = new System.Windows.Forms.Button();
            this.btnConfirmar_Agregar = new System.Windows.Forms.Button();
            this.txtPrecio_Agregar = new System.Windows.Forms.TextBox();
            this.txtNombre_Agregar = new System.Windows.Forms.TextBox();
            this.dgvAgregar = new System.Windows.Forms.DataGridView();
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
            this.btnSalir_Actualizar = new System.Windows.Forms.Button();
            this.btnRegresar_Actualizar = new System.Windows.Forms.Button();
            this.btnConfirmar_Actualizar = new System.Windows.Forms.Button();
            this.txtPrecio_Actualizar = new System.Windows.Forms.TextBox();
            this.txtNombre_Actualizar = new System.Windows.Forms.TextBox();
            this.txtCodigo_Actualizar = new System.Windows.Forms.TextBox();
            this.dgvActualizar = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tpEliminar = new System.Windows.Forms.TabPage();
            this.btnSalir_Eliminar = new System.Windows.Forms.Button();
            this.btnRegresar_Eliminar = new System.Windows.Forms.Button();
            this.btnConfirmar_Eliminar = new System.Windows.Forms.Button();
            this.txtCodigo_Eliminar = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvEliminar = new System.Windows.Forms.DataGridView();
            this.lblCodigo_Eliminar = new System.Windows.Forms.Label();
            this.tbcServicios.SuspendLayout();
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
            // tbcServicios
            // 
            this.tbcServicios.Controls.Add(this.tpAgregar);
            this.tbcServicios.Controls.Add(this.tpConsultar);
            this.tbcServicios.Controls.Add(this.tpActualizar);
            this.tbcServicios.Controls.Add(this.tpEliminar);
            this.tbcServicios.Location = new System.Drawing.Point(-4, 3);
            this.tbcServicios.Name = "tbcServicios";
            this.tbcServicios.SelectedIndex = 0;
            this.tbcServicios.Size = new System.Drawing.Size(1195, 562);
            this.tbcServicios.TabIndex = 2;
            this.tbcServicios.SelectedIndexChanged += new System.EventHandler(this.tbcServicios_SelectedIndexChanged);
            // 
            // tpAgregar
            // 
            this.tpAgregar.Controls.Add(this.btnSalir_Agregar);
            this.tpAgregar.Controls.Add(this.btnRegresar_Agregar);
            this.tpAgregar.Controls.Add(this.btnConfirmar_Agregar);
            this.tpAgregar.Controls.Add(this.txtPrecio_Agregar);
            this.tpAgregar.Controls.Add(this.txtNombre_Agregar);
            this.tpAgregar.Controls.Add(this.dgvAgregar);
            this.tpAgregar.Controls.Add(this.label4);
            this.tpAgregar.Controls.Add(this.label3);
            this.tpAgregar.Controls.Add(this.label7);
            this.tpAgregar.Location = new System.Drawing.Point(4, 25);
            this.tpAgregar.Name = "tpAgregar";
            this.tpAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAgregar.Size = new System.Drawing.Size(1187, 533);
            this.tpAgregar.TabIndex = 0;
            this.tpAgregar.Text = "Agregar";
            this.tpAgregar.UseVisualStyleBackColor = true;
            // 
            // btnSalir_Agregar
            // 
            this.btnSalir_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir_Agregar.Image")));
            this.btnSalir_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir_Agregar.Location = new System.Drawing.Point(941, 437);
            this.btnSalir_Agregar.Name = "btnSalir_Agregar";
            this.btnSalir_Agregar.Size = new System.Drawing.Size(156, 36);
            this.btnSalir_Agregar.TabIndex = 108;
            this.btnSalir_Agregar.Text = "Salir";
            this.btnSalir_Agregar.UseVisualStyleBackColor = true;
            this.btnSalir_Agregar.Click += new System.EventHandler(this.btnSalir_Agregar_Click);
            // 
            // btnRegresar_Agregar
            // 
            this.btnRegresar_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar_Agregar.Image")));
            this.btnRegresar_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar_Agregar.Location = new System.Drawing.Point(758, 437);
            this.btnRegresar_Agregar.Name = "btnRegresar_Agregar";
            this.btnRegresar_Agregar.Size = new System.Drawing.Size(156, 36);
            this.btnRegresar_Agregar.TabIndex = 107;
            this.btnRegresar_Agregar.Text = "Regresar";
            this.btnRegresar_Agregar.UseVisualStyleBackColor = true;
            this.btnRegresar_Agregar.Click += new System.EventHandler(this.btnRegresar_Agregar_Click);
            // 
            // btnConfirmar_Agregar
            // 
            this.btnConfirmar_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar_Agregar.Image")));
            this.btnConfirmar_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar_Agregar.Location = new System.Drawing.Point(572, 437);
            this.btnConfirmar_Agregar.Name = "btnConfirmar_Agregar";
            this.btnConfirmar_Agregar.Size = new System.Drawing.Size(156, 36);
            this.btnConfirmar_Agregar.TabIndex = 106;
            this.btnConfirmar_Agregar.Text = "Confirmar";
            this.btnConfirmar_Agregar.UseVisualStyleBackColor = true;
            this.btnConfirmar_Agregar.Click += new System.EventHandler(this.btnConfirmar_Agregar_Click);
            // 
            // txtPrecio_Agregar
            // 
            this.txtPrecio_Agregar.Location = new System.Drawing.Point(225, 306);
            this.txtPrecio_Agregar.Name = "txtPrecio_Agregar";
            this.txtPrecio_Agregar.Size = new System.Drawing.Size(170, 22);
            this.txtPrecio_Agregar.TabIndex = 105;
            // 
            // txtNombre_Agregar
            // 
            this.txtNombre_Agregar.Location = new System.Drawing.Point(225, 252);
            this.txtNombre_Agregar.Name = "txtNombre_Agregar";
            this.txtNombre_Agregar.Size = new System.Drawing.Size(170, 22);
            this.txtNombre_Agregar.TabIndex = 104;
            // 
            // dgvAgregar
            // 
            this.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregar.Location = new System.Drawing.Point(525, 156);
            this.dgvAgregar.Name = "dgvAgregar";
            this.dgvAgregar.RowHeadersWidth = 51;
            this.dgvAgregar.RowTemplate.Height = 24;
            this.dgvAgregar.Size = new System.Drawing.Size(604, 251);
            this.dgvAgregar.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 101;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 100;
            this.label3.Text = "Nombre Servicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(455, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 48);
            this.label7.TabIndex = 86;
            this.label7.Text = "Agregar Servicio";
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
            // tpActualizar
            // 
            this.tpActualizar.Controls.Add(this.btnSalir_Actualizar);
            this.tpActualizar.Controls.Add(this.btnRegresar_Actualizar);
            this.tpActualizar.Controls.Add(this.btnConfirmar_Actualizar);
            this.tpActualizar.Controls.Add(this.txtPrecio_Actualizar);
            this.tpActualizar.Controls.Add(this.txtNombre_Actualizar);
            this.tpActualizar.Controls.Add(this.txtCodigo_Actualizar);
            this.tpActualizar.Controls.Add(this.dgvActualizar);
            this.tpActualizar.Controls.Add(this.label5);
            this.tpActualizar.Controls.Add(this.label6);
            this.tpActualizar.Controls.Add(this.label8);
            this.tpActualizar.Controls.Add(this.label14);
            this.tpActualizar.Location = new System.Drawing.Point(4, 25);
            this.tpActualizar.Name = "tpActualizar";
            this.tpActualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tpActualizar.Size = new System.Drawing.Size(1187, 533);
            this.tpActualizar.TabIndex = 2;
            this.tpActualizar.Text = "Actualizar";
            this.tpActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir_Actualizar
            // 
            this.btnSalir_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir_Actualizar.Image")));
            this.btnSalir_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir_Actualizar.Location = new System.Drawing.Point(941, 436);
            this.btnSalir_Actualizar.Name = "btnSalir_Actualizar";
            this.btnSalir_Actualizar.Size = new System.Drawing.Size(156, 36);
            this.btnSalir_Actualizar.TabIndex = 119;
            this.btnSalir_Actualizar.Text = "Salir";
            this.btnSalir_Actualizar.UseVisualStyleBackColor = true;
            this.btnSalir_Actualizar.Click += new System.EventHandler(this.btnSalir_Actualizar_Click);
            // 
            // btnRegresar_Actualizar
            // 
            this.btnRegresar_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar_Actualizar.Image")));
            this.btnRegresar_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar_Actualizar.Location = new System.Drawing.Point(758, 436);
            this.btnRegresar_Actualizar.Name = "btnRegresar_Actualizar";
            this.btnRegresar_Actualizar.Size = new System.Drawing.Size(156, 36);
            this.btnRegresar_Actualizar.TabIndex = 118;
            this.btnRegresar_Actualizar.Text = "Regresar";
            this.btnRegresar_Actualizar.UseVisualStyleBackColor = true;
            this.btnRegresar_Actualizar.Click += new System.EventHandler(this.btnRegresar_Actualizar_Click);
            // 
            // btnConfirmar_Actualizar
            // 
            this.btnConfirmar_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar_Actualizar.Image")));
            this.btnConfirmar_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar_Actualizar.Location = new System.Drawing.Point(572, 436);
            this.btnConfirmar_Actualizar.Name = "btnConfirmar_Actualizar";
            this.btnConfirmar_Actualizar.Size = new System.Drawing.Size(156, 36);
            this.btnConfirmar_Actualizar.TabIndex = 117;
            this.btnConfirmar_Actualizar.Text = "Confirmar";
            this.btnConfirmar_Actualizar.UseVisualStyleBackColor = true;
            this.btnConfirmar_Actualizar.Click += new System.EventHandler(this.btnConfirmar_Actualizar_Click);
            // 
            // txtPrecio_Actualizar
            // 
            this.txtPrecio_Actualizar.Location = new System.Drawing.Point(225, 328);
            this.txtPrecio_Actualizar.Name = "txtPrecio_Actualizar";
            this.txtPrecio_Actualizar.Size = new System.Drawing.Size(170, 22);
            this.txtPrecio_Actualizar.TabIndex = 116;
            // 
            // txtNombre_Actualizar
            // 
            this.txtNombre_Actualizar.Location = new System.Drawing.Point(225, 274);
            this.txtNombre_Actualizar.Name = "txtNombre_Actualizar";
            this.txtNombre_Actualizar.Size = new System.Drawing.Size(170, 22);
            this.txtNombre_Actualizar.TabIndex = 115;
            // 
            // txtCodigo_Actualizar
            // 
            this.txtCodigo_Actualizar.Location = new System.Drawing.Point(225, 221);
            this.txtCodigo_Actualizar.Name = "txtCodigo_Actualizar";
            this.txtCodigo_Actualizar.Size = new System.Drawing.Size(170, 22);
            this.txtCodigo_Actualizar.TabIndex = 114;
            // 
            // dgvActualizar
            // 
            this.dgvActualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActualizar.Location = new System.Drawing.Point(525, 155);
            this.dgvActualizar.Name = "dgvActualizar";
            this.dgvActualizar.RowHeadersWidth = 51;
            this.dgvActualizar.RowTemplate.Height = 24;
            this.dgvActualizar.Size = new System.Drawing.Size(604, 251);
            this.dgvActualizar.TabIndex = 113;
            this.dgvActualizar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActualizar_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 112;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 111;
            this.label6.Text = "Nombre Servicio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 110;
            this.label8.Text = "Codigo Servicio:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(424, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(282, 48);
            this.label14.TabIndex = 109;
            this.label14.Text = "Actualizar Servicio";
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
            this.tpEliminar.Size = new System.Drawing.Size(1187, 533);
            this.tpEliminar.TabIndex = 3;
            this.tpEliminar.Text = "Eliminar";
            this.tpEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir_Eliminar
            // 
            this.btnSalir_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir_Eliminar.Image")));
            this.btnSalir_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir_Eliminar.Location = new System.Drawing.Point(940, 436);
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
            this.btnRegresar_Eliminar.Location = new System.Drawing.Point(757, 436);
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
            this.btnConfirmar_Eliminar.Location = new System.Drawing.Point(571, 436);
            this.btnConfirmar_Eliminar.Name = "btnConfirmar_Eliminar";
            this.btnConfirmar_Eliminar.Size = new System.Drawing.Size(156, 36);
            this.btnConfirmar_Eliminar.TabIndex = 157;
            this.btnConfirmar_Eliminar.Text = "Confirmar";
            this.btnConfirmar_Eliminar.UseVisualStyleBackColor = true;
            this.btnConfirmar_Eliminar.Click += new System.EventHandler(this.btnConfirmar_Eliminar_Click);
            // 
            // txtCodigo_Eliminar
            // 
            this.txtCodigo_Eliminar.Location = new System.Drawing.Point(221, 274);
            this.txtCodigo_Eliminar.Name = "txtCodigo_Eliminar";
            this.txtCodigo_Eliminar.Size = new System.Drawing.Size(170, 22);
            this.txtCodigo_Eliminar.TabIndex = 155;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(424, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(267, 48);
            this.label21.TabIndex = 154;
            this.label21.Text = "Eliminar Servicio";
            // 
            // dgvEliminar
            // 
            this.dgvEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminar.Location = new System.Drawing.Point(531, 144);
            this.dgvEliminar.Name = "dgvEliminar";
            this.dgvEliminar.RowHeadersWidth = 51;
            this.dgvEliminar.RowTemplate.Height = 24;
            this.dgvEliminar.Size = new System.Drawing.Size(604, 251);
            this.dgvEliminar.TabIndex = 153;
            this.dgvEliminar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEliminar_CellClick);
            // 
            // lblCodigo_Eliminar
            // 
            this.lblCodigo_Eliminar.AutoSize = true;
            this.lblCodigo_Eliminar.Location = new System.Drawing.Point(54, 280);
            this.lblCodigo_Eliminar.Name = "lblCodigo_Eliminar";
            this.lblCodigo_Eliminar.Size = new System.Drawing.Size(106, 16);
            this.lblCodigo_Eliminar.TabIndex = 151;
            this.lblCodigo_Eliminar.Text = "Codigo Servicio:";
            // 
            // Form_Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 561);
            this.Controls.Add(this.tbcServicios);
            this.Name = "Form_Servicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Form_Servicios_Load);
            this.tbcServicios.ResumeLayout(false);
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

        private System.Windows.Forms.TabControl tbcServicios;
        private System.Windows.Forms.TabPage tpAgregar;
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tpEliminar;
        private System.Windows.Forms.Button btnSalir_Eliminar;
        private System.Windows.Forms.Button btnRegresar_Eliminar;
        private System.Windows.Forms.Button btnConfirmar_Eliminar;
        private System.Windows.Forms.TextBox txtCodigo_Eliminar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvEliminar;
        private System.Windows.Forms.Label lblCodigo_Eliminar;
        private System.Windows.Forms.Button btnSalir_Agregar;
        private System.Windows.Forms.Button btnRegresar_Agregar;
        private System.Windows.Forms.Button btnConfirmar_Agregar;
        private System.Windows.Forms.TextBox txtPrecio_Agregar;
        private System.Windows.Forms.TextBox txtNombre_Agregar;
        private System.Windows.Forms.DataGridView dgvAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir_Actualizar;
        private System.Windows.Forms.Button btnRegresar_Actualizar;
        private System.Windows.Forms.Button btnConfirmar_Actualizar;
        private System.Windows.Forms.TextBox txtPrecio_Actualizar;
        private System.Windows.Forms.TextBox txtNombre_Actualizar;
        private System.Windows.Forms.TextBox txtCodigo_Actualizar;
        private System.Windows.Forms.DataGridView dgvActualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}