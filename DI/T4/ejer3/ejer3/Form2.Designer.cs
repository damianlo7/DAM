namespace ejer3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seAjustaPerfectamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinDeformaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seAjustaPerfectamenteToolStripMenuItem,
            this.sinDeformaseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 48);
            // 
            // seAjustaPerfectamenteToolStripMenuItem
            // 
            this.seAjustaPerfectamenteToolStripMenuItem.Name = "seAjustaPerfectamenteToolStripMenuItem";
            this.seAjustaPerfectamenteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.seAjustaPerfectamenteToolStripMenuItem.Text = "Se ajusta perfectamente";
            this.seAjustaPerfectamenteToolStripMenuItem.Click += new System.EventHandler(this.seAjustaPerfectamenteToolStripMenuItem_Click);
            // 
            // sinDeformaseToolStripMenuItem
            // 
            this.sinDeformaseToolStripMenuItem.Name = "sinDeformaseToolStripMenuItem";
            this.sinDeformaseToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sinDeformaseToolStripMenuItem.Text = "Sin deformase";
            this.sinDeformaseToolStripMenuItem.Click += new System.EventHandler(this.sinDeformaseToolStripMenuItem_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(318, 175);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Secundario";
            this.Resize += new System.EventHandler(this.Form2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seAjustaPerfectamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinDeformaseToolStripMenuItem;
        private System.Windows.Forms.Label lblError;
    }
}