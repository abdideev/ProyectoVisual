﻿namespace GestionEmpresa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EntrarBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.NoCuentaTxt = new System.Windows.Forms.TextBox();
            this.NIPTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE GASTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "BIENVENIDOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "NO. CUENTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIP";
            // 
            // EntrarBtn
            // 
            this.EntrarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.EntrarBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntrarBtn.Location = new System.Drawing.Point(129, 373);
            this.EntrarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntrarBtn.Name = "EntrarBtn";
            this.EntrarBtn.Size = new System.Drawing.Size(259, 64);
            this.EntrarBtn.TabIndex = 4;
            this.EntrarBtn.Text = "INGRESAR";
            this.EntrarBtn.UseVisualStyleBackColor = false;
            // 
            // SalirBtn
            // 
            this.SalirBtn.BackColor = System.Drawing.Color.LightCoral;
            this.SalirBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirBtn.Location = new System.Drawing.Point(129, 455);
            this.SalirBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(259, 64);
            this.SalirBtn.TabIndex = 5;
            this.SalirBtn.Text = "SALIR";
            this.SalirBtn.UseVisualStyleBackColor = false;
            // 
            // NoCuentaTxt
            // 
            this.NoCuentaTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.NoCuentaTxt.Location = new System.Drawing.Point(149, 215);
            this.NoCuentaTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NoCuentaTxt.Name = "NoCuentaTxt";
            this.NoCuentaTxt.Size = new System.Drawing.Size(211, 22);
            this.NoCuentaTxt.TabIndex = 6;
            this.NoCuentaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NIPTxt
            // 
            this.NIPTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NIPTxt.Location = new System.Drawing.Point(149, 299);
            this.NIPTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NIPTxt.Name = "NIPTxt";
            this.NIPTxt.PasswordChar = '•';
            this.NIPTxt.Size = new System.Drawing.Size(211, 22);
            this.NIPTxt.TabIndex = 7;
            this.NIPTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NIPTxt.TextChanged += new System.EventHandler(this.NIPTxt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(500, 555);
            this.Controls.Add(this.NIPTxt);
            this.Controls.Add(this.NoCuentaTxt);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.EntrarBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EntrarBtn;
        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.TextBox NoCuentaTxt;
        private System.Windows.Forms.TextBox NIPTxt;
    }
}

