namespace PhotoBlogConverter
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.chBRecursion = new System.Windows.Forms.CheckBox();
            this.btnSaveFolder = new System.Windows.Forms.Button();
            this.btnSourceFolder = new System.Windows.Forms.Button();
            this.txtSaveFolder = new System.Windows.Forms.TextBox();
            this.tbSourceFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOutputHeight = new System.Windows.Forms.TextBox();
            this.tbOutputWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btProccess = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(21, 263);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(345, 23);
            this.pbStatus.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Resize";
            // 
            // chBRecursion
            // 
            this.chBRecursion.AutoSize = true;
            this.chBRecursion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBRecursion.Location = new System.Drawing.Point(129, 80);
            this.chBRecursion.Name = "chBRecursion";
            this.chBRecursion.Size = new System.Drawing.Size(132, 17);
            this.chBRecursion.TabIndex = 13;
            this.chBRecursion.Text = "Include Subfolders";
            this.chBRecursion.UseVisualStyleBackColor = true;
            // 
            // btnSaveFolder
            // 
            this.btnSaveFolder.Location = new System.Drawing.Point(339, 53);
            this.btnSaveFolder.Name = "btnSaveFolder";
            this.btnSaveFolder.Size = new System.Drawing.Size(28, 20);
            this.btnSaveFolder.TabIndex = 5;
            this.btnSaveFolder.Text = "...";
            this.btnSaveFolder.UseVisualStyleBackColor = true;
            this.btnSaveFolder.Click += new System.EventHandler(this.btnSaveFolder_Click);
            // 
            // btnSourceFolder
            // 
            this.btnSourceFolder.Location = new System.Drawing.Point(339, 28);
            this.btnSourceFolder.Name = "btnSourceFolder";
            this.btnSourceFolder.Size = new System.Drawing.Size(28, 20);
            this.btnSourceFolder.TabIndex = 4;
            this.btnSourceFolder.Text = "...";
            this.btnSourceFolder.UseVisualStyleBackColor = true;
            this.btnSourceFolder.Click += new System.EventHandler(this.btnSourceFolder_Click);
            // 
            // txtSaveFolder
            // 
            this.txtSaveFolder.Location = new System.Drawing.Point(129, 54);
            this.txtSaveFolder.Name = "txtSaveFolder";
            this.txtSaveFolder.Size = new System.Drawing.Size(203, 20);
            this.txtSaveFolder.TabIndex = 3;
            // 
            // tbSourceFolder
            // 
            this.tbSourceFolder.Location = new System.Drawing.Point(129, 28);
            this.tbSourceFolder.Name = "tbSourceFolder";
            this.tbSourceFolder.Size = new System.Drawing.Size(203, 20);
            this.tbSourceFolder.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Save Folder: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "x";
            // 
            // tbOutputHeight
            // 
            this.tbOutputHeight.Location = new System.Drawing.Point(109, 33);
            this.tbOutputHeight.Name = "tbOutputHeight";
            this.tbOutputHeight.Size = new System.Drawing.Size(35, 20);
            this.tbOutputHeight.TabIndex = 10;
            this.tbOutputHeight.Text = "240";
            // 
            // tbOutputWidth
            // 
            this.tbOutputWidth.Location = new System.Drawing.Point(51, 33);
            this.tbOutputWidth.Name = "tbOutputWidth";
            this.tbOutputWidth.Size = new System.Drawing.Size(36, 20);
            this.tbOutputWidth.TabIndex = 9;
            this.tbOutputWidth.Text = "240";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Folder: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(108, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "height";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(18, 293);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Waiting...";
            // 
            // btProccess
            // 
            this.btProccess.Location = new System.Drawing.Point(21, 225);
            this.btProccess.Name = "btProccess";
            this.btProccess.Size = new System.Drawing.Size(114, 32);
            this.btProccess.TabIndex = 10;
            this.btProccess.Text = "Process Files";
            this.btProccess.UseVisualStyleBackColor = true;
            this.btProccess.Click += new System.EventHandler(this.btProccess_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBRecursion);
            this.groupBox1.Controls.Add(this.btnSaveFolder);
            this.groupBox1.Controls.Add(this.btnSourceFolder);
            this.groupBox1.Controls.Add(this.txtSaveFolder);
            this.groupBox1.Controls.Add(this.tbSourceFolder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 115);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion Settings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(52, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "width";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbOutputHeight);
            this.groupBox2.Controls.Add(this.tbOutputWidth);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 85);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advanced Settings";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 315);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btProccess);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmPrincipal";
            this.Text = "Photo Blog Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chBRecursion;
        private System.Windows.Forms.Button btnSaveFolder;
        private System.Windows.Forms.Button btnSourceFolder;
        private System.Windows.Forms.TextBox txtSaveFolder;
        private System.Windows.Forms.TextBox tbSourceFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOutputHeight;
        private System.Windows.Forms.TextBox tbOutputWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btProccess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

