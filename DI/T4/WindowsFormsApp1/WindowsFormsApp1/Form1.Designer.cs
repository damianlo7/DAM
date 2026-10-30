namespace WindowsFormsApp1
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
            this.btnIzq = new System.Windows.Forms.Button();
            this.btnDer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIzq
            // 
            this.btnIzq.Location = new System.Drawing.Point(64, 330);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(75, 23);
            this.btnIzq.TabIndex = 0;
            this.btnIzq.Text = "IZQUIERDO";
            this.btnIzq.UseVisualStyleBackColor = true;
            this.btnIzq.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.btnIzq.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // btnDer
            // 
            this.btnDer.Location = new System.Drawing.Point(208, 330);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(75, 23);
            this.btnDer.TabIndex = 1;
            this.btnDer.Text = "DERECHO";
            this.btnDer.UseVisualStyleBackColor = true;
            this.btnDer.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.btnDer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 401);
            this.Controls.Add(this.btnDer);
            this.Controls.Add(this.btnIzq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzq;
        private System.Windows.Forms.Button btnDer;
    }
}

