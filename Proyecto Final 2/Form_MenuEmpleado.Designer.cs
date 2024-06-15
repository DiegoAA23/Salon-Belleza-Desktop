namespace Proyecto_Final_2
{
    partial class Form_MenuEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MenuEmpleado));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFaturacion = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnClietes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(341, 354);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 34);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFaturacion
            // 
            this.btnFaturacion.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturacion.Image")));
            this.btnFaturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaturacion.Location = new System.Drawing.Point(150, 284);
            this.btnFaturacion.Name = "btnFaturacion";
            this.btnFaturacion.Size = new System.Drawing.Size(162, 43);
            this.btnFaturacion.TabIndex = 20;
            this.btnFaturacion.Text = "Facturación";
            this.btnFaturacion.UseVisualStyleBackColor = true;
            this.btnFaturacion.Click += new System.EventHandler(this.btnFaturacion_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.Image = ((System.Drawing.Image)(resources.GetObject("btnServicios.Image")));
            this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.Location = new System.Drawing.Point(150, 212);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(162, 43);
            this.btnServicios.TabIndex = 19;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnClietes
            // 
            this.btnClietes.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClietes.Image = ((System.Drawing.Image)(resources.GetObject("btnClietes.Image")));
            this.btnClietes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClietes.Location = new System.Drawing.Point(150, 136);
            this.btnClietes.Name = "btnClietes";
            this.btnClietes.Size = new System.Drawing.Size(162, 43);
            this.btnClietes.TabIndex = 18;
            this.btnClietes.Text = "Clientes";
            this.btnClietes.UseVisualStyleBackColor = true;
            this.btnClietes.Click += new System.EventHandler(this.btnClietes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Menú Empleado";
            // 
            // Form_MenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 416);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFaturacion);
            this.Controls.Add(this.btnServicios);
            this.Controls.Add(this.btnClietes);
            this.Controls.Add(this.label1);
            this.Name = "Form_MenuEmpleado";
            this.Text = "Menu Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFaturacion;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnClietes;
        private System.Windows.Forms.Label label1;
    }
}