﻿namespace Proyecto_Final_2
{
    partial class CargarEmpleado
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
            this.components = new System.ComponentModel.Container();
            this.ProcesBar = new System.Windows.Forms.ProgressBar();
            this.btnstart = new System.Windows.Forms.Button();
            this.lbldone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ProcesBar
            // 
            this.ProcesBar.Location = new System.Drawing.Point(60, 113);
            this.ProcesBar.Name = "ProcesBar";
            this.ProcesBar.Size = new System.Drawing.Size(199, 23);
            this.ProcesBar.TabIndex = 7;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(114, 152);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(98, 34);
            this.btnstart.TabIndex = 6;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lbldone
            // 
            this.lbldone.AutoSize = true;
            this.lbldone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldone.Location = new System.Drawing.Point(142, 90);
            this.lbldone.Name = "lbldone";
            this.lbldone.Size = new System.Drawing.Size(13, 20);
            this.lbldone.TabIndex = 5;
            this.lbldone.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loading...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CargarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 208);
            this.Controls.Add(this.ProcesBar);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lbldone);
            this.Controls.Add(this.label1);
            this.Name = "CargarEmpleado";
            this.Text = "CargarEmpleado";
            this.Load += new System.EventHandler(this.CargarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProcesBar;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label lbldone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}