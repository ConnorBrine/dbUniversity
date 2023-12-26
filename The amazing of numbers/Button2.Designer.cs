namespace The_amazing_of_numbers
{
    partial class Button2
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DarkMode = new System.Windows.Forms.Label();
            this.lightdarkmodebtn = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DarkMode
            // 
            this.DarkMode.AutoSize = true;
            this.DarkMode.BackColor = System.Drawing.Color.Transparent;
            this.DarkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarkMode.Location = new System.Drawing.Point(328, 29);
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.Size = new System.Drawing.Size(140, 29);
            this.DarkMode.TabIndex = 11;
            this.DarkMode.Text = "Dark mode";
            // 
            // lightdarkmodebtn
            // 
            this.lightdarkmodebtn.Animated = true;
            this.lightdarkmodebtn.BackColor = System.Drawing.Color.Transparent;
            this.lightdarkmodebtn.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.lightdarkmodebtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.lightdarkmodebtn.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.lightdarkmodebtn.CheckedState.InnerColor = System.Drawing.Color.Black;
            this.lightdarkmodebtn.Location = new System.Drawing.Point(220, 73);
            this.lightdarkmodebtn.Name = "lightdarkmodebtn";
            this.lightdarkmodebtn.Size = new System.Drawing.Size(341, 93);
            this.lightdarkmodebtn.TabIndex = 10;
            this.lightdarkmodebtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lightdarkmodebtn.UncheckedState.FillColor = System.Drawing.Color.Black;
            this.lightdarkmodebtn.UncheckedState.InnerBorderColor = System.Drawing.Color.Yellow;
            this.lightdarkmodebtn.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.lightdarkmodebtn.CheckedChanged += new System.EventHandler(this.lightdarkmodebtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(241, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "The Text look like this!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Button2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DarkMode);
            this.Controls.Add(this.lightdarkmodebtn);
            this.Name = "Button2";
            this.Text = "Button2";
            this.Load += new System.EventHandler(this.Button2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label DarkMode;
        private Guna.UI2.WinForms.Guna2ToggleSwitch lightdarkmodebtn;
        private System.Windows.Forms.Label label1;
    }
}