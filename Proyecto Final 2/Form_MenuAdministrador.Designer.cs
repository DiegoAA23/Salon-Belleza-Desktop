namespace Proyecto_Final_2
{
    partial class Form_MenuAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MenuAdministrador));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(382, 483);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 34);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(184, 416);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(162, 43);
            this.btnFacturacion.TabIndex = 16;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.Image = ((System.Drawing.Image)(resources.GetObject("btnServicios.Image")));
            this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.Location = new System.Drawing.Point(184, 343);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(162, 43);
            this.btnServicios.TabIndex = 15;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(184, 264);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(162, 43);
            this.btnUsuarios.TabIndex = 14;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(184, 183);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(162, 43);
            this.btnClientes.TabIndex = 13;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Menú Administrador";
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(184, 104);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(162, 43);
            this.btnEmpleados.TabIndex = 11;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // Form_MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 556);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnServicios);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmpleados);
            this.Name = "Form_MenuAdministrador";
            this.Text = "Menu Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpleados;
    }
}