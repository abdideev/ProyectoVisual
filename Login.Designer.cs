namespace GestionEmpresa
{
    partial class Login
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
            this.IngresarBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.NoCuentaTxt = new System.Windows.Forms.TextBox();
            this.NIPTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE GASTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "BIENVENIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIP";
            // 
            // IngresarBtn
            // 
            this.IngresarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.IngresarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IngresarBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarBtn.Location = new System.Drawing.Point(97, 303);
            this.IngresarBtn.Name = "IngresarBtn";
            this.IngresarBtn.Size = new System.Drawing.Size(194, 52);
            this.IngresarBtn.TabIndex = 4;
            this.IngresarBtn.Text = "INGRESAR";
            this.IngresarBtn.UseVisualStyleBackColor = false;
            this.IngresarBtn.Click += new System.EventHandler(this.EntrarBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.BackColor = System.Drawing.Color.LightCoral;
            this.SalirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalirBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirBtn.Location = new System.Drawing.Point(97, 370);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(194, 52);
            this.SalirBtn.TabIndex = 5;
            this.SalirBtn.Text = "SALIR";
            this.SalirBtn.UseVisualStyleBackColor = false;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // NoCuentaTxt
            // 
            this.NoCuentaTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.NoCuentaTxt.Location = new System.Drawing.Point(112, 175);
            this.NoCuentaTxt.Name = "NoCuentaTxt";
            this.NoCuentaTxt.Size = new System.Drawing.Size(159, 20);
            this.NoCuentaTxt.TabIndex = 6;
            this.NoCuentaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NIPTxt
            // 
            this.NIPTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NIPTxt.Location = new System.Drawing.Point(112, 243);
            this.NIPTxt.Name = "NIPTxt";
            this.NIPTxt.PasswordChar = '•';
            this.NIPTxt.Size = new System.Drawing.Size(159, 20);
            this.NIPTxt.TabIndex = 7;
            this.NIPTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "CUSTOMIX";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(375, 451);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NIPTxt);
            this.Controls.Add(this.NoCuentaTxt);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.IngresarBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Login";
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
        private System.Windows.Forms.Button IngresarBtn;
        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.TextBox NoCuentaTxt;
        private System.Windows.Forms.TextBox NIPTxt;
        private System.Windows.Forms.Label label5;
    }
}

