﻿namespace The_amazing_of_numbers.Area.Lecturer.View
{
    partial class LecturerMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.calendarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lecturer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Register Class";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calendarbtn
            // 
            this.calendarbtn.Location = new System.Drawing.Point(384, 13);
            this.calendarbtn.Name = "calendarbtn";
            this.calendarbtn.Size = new System.Drawing.Size(145, 55);
            this.calendarbtn.TabIndex = 2;
            this.calendarbtn.Text = "Lịch";
            this.calendarbtn.UseVisualStyleBackColor = true;
            this.calendarbtn.Click += new System.EventHandler(this.calendarbtn_Click);
            // 
            // LecturerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calendarbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "LecturerMainForm";
            this.Text = "LecturerMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calendarbtn;
    }
}