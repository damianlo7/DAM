namespace ejer3
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
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnhadirC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(119, 85);
            this.txb1.Name = "txb1";
            this.txb1.ReadOnly = true;
            this.txb1.Size = new System.Drawing.Size(38, 20);
            this.txb1.TabIndex = 0;
            // 
            // txb3
            // 
            this.txb3.Location = new System.Drawing.Point(303, 85);
            this.txb3.Name = "txb3";
            this.txb3.ReadOnly = true;
            this.txb3.Size = new System.Drawing.Size(38, 20);
            this.txb3.TabIndex = 2;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(208, 85);
            this.txb2.Name = "txb2";
            this.txb2.ReadOnly = true;
            this.txb2.Size = new System.Drawing.Size(38, 20);
            this.txb2.TabIndex = 1;
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Yellow;
            this.btnJugar.Location = new System.Drawing.Point(189, 171);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 5;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(164, 42);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 13);
            this.lblRes.TabIndex = 0;
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(84, 176);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(35, 13);
            this.lblCredito.TabIndex = 4;
            this.lblCredito.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Credito: ";
            // 
            // btnAnhadirC
            // 
            this.btnAnhadirC.BackColor = System.Drawing.Color.Red;
            this.btnAnhadirC.Location = new System.Drawing.Point(317, 154);
            this.btnAnhadirC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnhadirC.Name = "btnAnhadirC";
            this.btnAnhadirC.Size = new System.Drawing.Size(70, 57);
            this.btnAnhadirC.TabIndex = 6;
            this.btnAnhadirC.Text = "Añadir Creditos";
            this.btnAnhadirC.UseVisualStyleBackColor = false;
            this.btnAnhadirC.Click += new System.EventHandler(this.btnAnhadirC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 237);
            this.Controls.Add(this.btnAnhadirC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb3);
            this.Controls.Add(this.txb1);
            this.Name = "Form1";
            this.Text = "Tragaperras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnhadirC;
    }
}

