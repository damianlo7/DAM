namespace ejer4
{
    partial class ejer4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejer4));
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.btnAnhadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTranspasar = new System.Windows.Forms.Button();
            this.tbx = new System.Windows.Forms.TextBox();
            this.lblElementos = new System.Windows.Forms.Label();
            this.lblIndices = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbL2 = new System.Windows.Forms.RadioButton();
            this.rbL1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbT21 = new System.Windows.Forms.RadioButton();
            this.rbT12 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(90, 37);
            this.lb1.Name = "lb1";
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb1.Size = new System.Drawing.Size(120, 95);
            this.lb1.TabIndex = 0;
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.lb1_SelectedIndexChanged);
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(498, 37);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(120, 95);
            this.lb2.TabIndex = 1;
            // 
            // btnAnhadir
            // 
            this.btnAnhadir.Location = new System.Drawing.Point(90, 165);
            this.btnAnhadir.Name = "btnAnhadir";
            this.btnAnhadir.Size = new System.Drawing.Size(98, 23);
            this.btnAnhadir.TabIndex = 2;
            this.btnAnhadir.Text = "Añadir";
            this.toolTip1.SetToolTip(this.btnAnhadir, "Añade texto en la lista 1");
            this.btnAnhadir.UseVisualStyleBackColor = true;
            this.btnAnhadir.Click += new System.EventHandler(this.btnAnhadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(90, 194);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminar, "Elimina los elementos seleccionados en la lista elegida");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnTranspasar
            // 
            this.btnTranspasar.Location = new System.Drawing.Point(90, 223);
            this.btnTranspasar.Name = "btnTranspasar";
            this.btnTranspasar.Size = new System.Drawing.Size(98, 23);
            this.btnTranspasar.TabIndex = 5;
            this.btnTranspasar.Text = "Transpasar";
            this.toolTip1.SetToolTip(this.btnTranspasar, "pasa los elementos seleccionados entre listas");
            this.btnTranspasar.UseVisualStyleBackColor = true;
            this.btnTranspasar.Click += new System.EventHandler(this.btnTranspasar_Click);
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(194, 167);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(100, 20);
            this.tbx.TabIndex = 3;
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.Location = new System.Drawing.Point(216, 46);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(62, 13);
            this.lblElementos.TabIndex = 6;
            this.lblElementos.Text = "Elementos: ";
            // 
            // lblIndices
            // 
            this.lblIndices.AutoSize = true;
            this.lblIndices.Location = new System.Drawing.Point(216, 78);
            this.lblIndices.Name = "lblIndices";
            this.lblIndices.Size = new System.Drawing.Size(118, 13);
            this.lblIndices.TabIndex = 7;
            this.lblIndices.Text = "Indices seleccionados: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbL2);
            this.groupBox1.Controls.Add(this.rbL1);
            this.groupBox1.Location = new System.Drawing.Point(273, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista borrar";
            // 
            // rbL2
            // 
            this.rbL2.AutoSize = true;
            this.rbL2.Location = new System.Drawing.Point(88, 45);
            this.rbL2.Name = "rbL2";
            this.rbL2.Size = new System.Drawing.Size(56, 17);
            this.rbL2.TabIndex = 7;
            this.rbL2.Text = "Lista 2";
            this.rbL2.UseVisualStyleBackColor = true;
            this.rbL2.CheckedChanged += new System.EventHandler(this.rbL_CheckedChanged);
            // 
            // rbL1
            // 
            this.rbL1.AutoSize = true;
            this.rbL1.Checked = true;
            this.rbL1.Location = new System.Drawing.Point(7, 45);
            this.rbL1.Name = "rbL1";
            this.rbL1.Size = new System.Drawing.Size(56, 17);
            this.rbL1.TabIndex = 6;
            this.rbL1.TabStop = true;
            this.rbL1.Text = "Lista 1";
            this.rbL1.UseVisualStyleBackColor = true;
            this.rbL1.CheckedChanged += new System.EventHandler(this.rbL_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbT21);
            this.groupBox2.Controls.Add(this.rbT12);
            this.groupBox2.Location = new System.Drawing.Point(477, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista transpaso";
            // 
            // rbT21
            // 
            this.rbT21.AutoSize = true;
            this.rbT21.Location = new System.Drawing.Point(157, 45);
            this.rbT21.Name = "rbT21";
            this.rbT21.Size = new System.Drawing.Size(99, 17);
            this.rbT21.TabIndex = 9;
            this.rbT21.Text = "Transpaso 2->1";
            this.rbT21.UseVisualStyleBackColor = true;
            this.rbT21.CheckedChanged += new System.EventHandler(this.rbT_CheckedChanged);
            // 
            // rbT12
            // 
            this.rbT12.AutoSize = true;
            this.rbT12.Checked = true;
            this.rbT12.Location = new System.Drawing.Point(42, 45);
            this.rbT12.Name = "rbT12";
            this.rbT12.Size = new System.Drawing.Size(99, 17);
            this.rbT12.TabIndex = 8;
            this.rbT12.TabStop = true;
            this.rbT12.Text = "Transpaso 1->2";
            this.rbT12.UseVisualStyleBackColor = true;
            this.rbT12.CheckedChanged += new System.EventHandler(this.rbT_CheckedChanged);
            // 
            // ejer4
            // 
            this.AcceptButton = this.btnAnhadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblIndices);
            this.Controls.Add(this.lblElementos);
            this.Controls.Add(this.tbx);
            this.Controls.Add(this.btnTranspasar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAnhadir);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ejer4";
            this.Text = "Multi formulario";
            this.Load += new System.EventHandler(this.ejer4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button btnAnhadir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnTranspasar;
        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.Label lblElementos;
        private System.Windows.Forms.Label lblIndices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbL2;
        private System.Windows.Forms.RadioButton rbL1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbT21;
        private System.Windows.Forms.RadioButton rbT12;
    }
}

