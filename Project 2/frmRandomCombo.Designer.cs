namespace Project_2
{
    partial class frmRandomCombo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoGreater = new System.Windows.Forms.RadioButton();
            this.rdoLess = new System.Windows.Forms.RadioButton();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbRandom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoGreater2 = new System.Windows.Forms.RadioButton();
            this.rdoLess2 = new System.Windows.Forms.RadioButton();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.cmbRandom2 = new System.Windows.Forms.ComboBox();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoGreater);
            this.groupBox1.Controls.Add(this.rdoLess);
            this.groupBox1.Controls.Add(this.BtnGenerate);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.cmbRandom);
            this.groupBox1.Location = new System.Drawing.Point(57, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz03_AAF19";
            // 
            // rdoGreater
            // 
            this.rdoGreater.AutoSize = true;
            this.rdoGreater.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGreater.Location = new System.Drawing.Point(168, 145);
            this.rdoGreater.Name = "rdoGreater";
            this.rdoGreater.Size = new System.Drawing.Size(157, 25);
            this.rdoGreater.TabIndex = 5;
            this.rdoGreater.TabStop = true;
            this.rdoGreater.Text = "Greater than 500";
            this.rdoGreater.UseVisualStyleBackColor = true;
            this.rdoGreater.CheckedChanged += new System.EventHandler(this.rdoGreater_CheckedChanged);
            // 
            // rdoLess
            // 
            this.rdoLess.AutoSize = true;
            this.rdoLess.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLess.Location = new System.Drawing.Point(168, 109);
            this.rdoLess.Name = "rdoLess";
            this.rdoLess.Size = new System.Drawing.Size(134, 25);
            this.rdoLess.TabIndex = 4;
            this.rdoLess.TabStop = true;
            this.rdoLess.Text = "Less than 500";
            this.rdoLess.UseVisualStyleBackColor = true;
            this.rdoLess.CheckedChanged += new System.EventHandler(this.rdoLess_CheckedChanged_1);
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnGenerate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate.Location = new System.Drawing.Point(168, 43);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(140, 43);
            this.BtnGenerate.TabIndex = 1;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(55, 236);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(232, 43);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // cmbRandom
            // 
            this.cmbRandom.FormattingEnabled = true;
            this.cmbRandom.Location = new System.Drawing.Point(6, 53);
            this.cmbRandom.Name = "cmbRandom";
            this.cmbRandom.Size = new System.Drawing.Size(121, 24);
            this.cmbRandom.TabIndex = 0;
            this.cmbRandom.SelectedIndexChanged += new System.EventHandler(this.cmbRandom_SelectedIndexChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rdoGreater2);
            this.groupBox2.Controls.Add(this.rdoLess2);
            this.groupBox2.Controls.Add(this.btnReset2);
            this.groupBox2.Controls.Add(this.cmbRandom2);
            this.groupBox2.Controls.Add(this.BtnGenerate2);
            this.groupBox2.Location = new System.Drawing.Point(466, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quiz03_EAF19";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Count:";
            // 
            // rdoGreater2
            // 
            this.rdoGreater2.AutoSize = true;
            this.rdoGreater2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGreater2.Location = new System.Drawing.Point(165, 145);
            this.rdoGreater2.Name = "rdoGreater2";
            this.rdoGreater2.Size = new System.Drawing.Size(148, 25);
            this.rdoGreater2.TabIndex = 7;
            this.rdoGreater2.TabStop = true;
            this.rdoGreater2.Text = "Greater than 50";
            this.rdoGreater2.UseVisualStyleBackColor = true;
            // 
            // rdoLess2
            // 
            this.rdoLess2.AutoSize = true;
            this.rdoLess2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLess2.Location = new System.Drawing.Point(165, 109);
            this.rdoLess2.Name = "rdoLess2";
            this.rdoLess2.Size = new System.Drawing.Size(125, 25);
            this.rdoLess2.TabIndex = 6;
            this.rdoLess2.TabStop = true;
            this.rdoLess2.Text = "Less than 50";
            this.rdoLess2.UseVisualStyleBackColor = true;
            // 
            // btnReset2
            // 
            this.btnReset2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.Location = new System.Drawing.Point(54, 236);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(232, 43);
            this.btnReset2.TabIndex = 4;
            this.btnReset2.Text = "Reset";
            this.btnReset2.UseVisualStyleBackColor = false;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click_1);
            // 
            // cmbRandom2
            // 
            this.cmbRandom2.FormattingEnabled = true;
            this.cmbRandom2.Location = new System.Drawing.Point(6, 53);
            this.cmbRandom2.Name = "cmbRandom2";
            this.cmbRandom2.Size = new System.Drawing.Size(121, 24);
            this.cmbRandom2.TabIndex = 1;
            this.cmbRandom2.SelectedIndexChanged += new System.EventHandler(this.cmbRandom2_SelectedIndexChanged_1);
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnGenerate2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate2.Location = new System.Drawing.Point(165, 43);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(140, 43);
            this.BtnGenerate2.TabIndex = 2;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = false;
            this.BtnGenerate2.Click += new System.EventHandler(this.BtnGenerate2_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnBack.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(771, 452);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(131, 56);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
            // 
            // frmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(914, 520);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRandomCombo";
            this.Text = "frmRandomCombo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoGreater;
        private System.Windows.Forms.RadioButton rdoLess;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbRandom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoGreater2;
        private System.Windows.Forms.RadioButton rdoLess2;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.ComboBox cmbRandom2;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.Button BtnBack;
    }
}