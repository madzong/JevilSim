﻿namespace JevilSim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.dlpercentage2 = new System.Windows.Forms.Label();
            this.dlpercentage1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(142, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Launch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 42);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(250, 46);
            this.progressBar1.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 94);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(250, 46);
            this.progressBar2.TabIndex = 4;
            // 
            // dlpercentage2
            // 
            this.dlpercentage2.AutoSize = true;
            this.dlpercentage2.BackColor = System.Drawing.Color.White;
            this.dlpercentage2.Location = new System.Drawing.Point(268, 111);
            this.dlpercentage2.Name = "dlpercentage2";
            this.dlpercentage2.Size = new System.Drawing.Size(23, 15);
            this.dlpercentage2.TabIndex = 6;
            this.dlpercentage2.Text = "0%";
            // 
            // dlpercentage1
            // 
            this.dlpercentage1.AutoSize = true;
            this.dlpercentage1.BackColor = System.Drawing.Color.White;
            this.dlpercentage1.Location = new System.Drawing.Point(268, 60);
            this.dlpercentage1.Name = "dlpercentage1";
            this.dlpercentage1.Size = new System.Drawing.Size(23, 15);
            this.dlpercentage1.TabIndex = 7;
            this.dlpercentage1.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Jevil Simulator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dlpercentage1);
            this.Controls.Add(this.dlpercentage2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(325, 216);
            this.MinimumSize = new System.Drawing.Size(325, 216);
            this.Name = "Form1";
            this.Text = "Jevil Simulator Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Button button2;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private Label dlpercentage2;
        private Label dlpercentage1;
        private Label label1;
    }
}