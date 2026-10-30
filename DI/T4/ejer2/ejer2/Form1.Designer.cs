namespace ejer2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSalir = new System.Windows.Forms.Button();
            this.txbR = new System.Windows.Forms.TextBox();
            this.txbG = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.tbRutaImagen = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(633, 436);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 19);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Tag = "salir";
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // txbR
            // 
            this.txbR.Location = new System.Drawing.Point(102, 64);
            this.txbR.Margin = new System.Windows.Forms.Padding(2);
            this.txbR.Name = "txbR";
            this.txbR.Size = new System.Drawing.Size(76, 20);
            this.txbR.TabIndex = 0;
            this.txbR.Tag = "color";
            this.txbR.Enter += new System.EventHandler(this.colores_Enter);
            // 
            // txbG
            // 
            this.txbG.Location = new System.Drawing.Point(256, 64);
            this.txbG.Margin = new System.Windows.Forms.Padding(2);
            this.txbG.Name = "txbG";
            this.txbG.Size = new System.Drawing.Size(76, 20);
            this.txbG.TabIndex = 1;
            this.txbG.Tag = "color";
            this.txbG.Enter += new System.EventHandler(this.colores_Enter);
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(411, 64);
            this.txbB.Margin = new System.Windows.Forms.Padding(2);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(76, 20);
            this.txbB.TabIndex = 2;
            this.txbB.Tag = "color";
            this.txbB.Enter += new System.EventHandler(this.colores_Enter);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnColor.Location = new System.Drawing.Point(229, 115);
            this.btnColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(129, 32);
            this.btnColor.TabIndex = 3;
            this.btnColor.Tag = "color";
            this.btnColor.Text = "COLOR";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            this.btnColor.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnColor.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // tbRutaImagen
            // 
            this.tbRutaImagen.Location = new System.Drawing.Point(102, 191);
            this.tbRutaImagen.Margin = new System.Windows.Forms.Padding(2);
            this.tbRutaImagen.Name = "tbRutaImagen";
            this.tbRutaImagen.Size = new System.Drawing.Size(194, 20);
            this.tbRutaImagen.TabIndex = 4;
            this.tbRutaImagen.Tag = "imagen";
            this.tbRutaImagen.Enter += new System.EventHandler(this.imagen_Enter);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(10, 191);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(70, 13);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Ruta imagen:";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(82, 67);
            this.lblR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(18, 13);
            this.lblR.TabIndex = 7;
            this.lblR.Text = "R:";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(236, 69);
            this.lblG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(18, 13);
            this.lblG.TabIndex = 8;
            this.lblG.Text = "G:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "B:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(200, 29);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 10;
            this.lblError.Tag = "lblError";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(386, 191);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(264, 193);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnImagen.Location = new System.Drawing.Point(152, 221);
            this.btnImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(99, 19);
            this.btnImagen.TabIndex = 5;
            this.btnImagen.Tag = "imagen";
            this.btnImagen.Text = "CARGAR IMAGEN";
            this.btnImagen.UseVisualStyleBackColor = false;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            this.btnImagen.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnImagen.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.Location = new System.Drawing.Point(561, 436);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(56, 19);
            this.btnReset.TabIndex = 6;
            this.btnReset.Tag = "reset";
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnColor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(700, 466);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tbRutaImagen);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txbG);
            this.Controls.Add(this.txbR);
            this.Controls.Add(this.btnSalir);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txbR;
        private System.Windows.Forms.TextBox txbG;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox tbRutaImagen;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Button btnReset;
    }
}

