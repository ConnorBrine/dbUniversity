namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    partial class AcademicAffairMainForm
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
            this.viewClass = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewCourse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Academic Affair";
            // 
            // viewClass
            // 
            this.viewClass.Location = new System.Drawing.Point(204, 9);
            this.viewClass.Name = "viewClass";
            this.viewClass.Size = new System.Drawing.Size(160, 73);
            this.viewClass.TabIndex = 2;
            this.viewClass.Text = "ViewClass";
            this.viewClass.UseVisualStyleBackColor = true;
            this.viewClass.Click += new System.EventHandler(this.viewClass_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(59, 403);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 16);
            this.username.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hello";
            // 
            // viewCourse
            // 
            this.viewCourse.Location = new System.Drawing.Point(406, 9);
            this.viewCourse.Name = "viewCourse";
            this.viewCourse.Size = new System.Drawing.Size(160, 73);
            this.viewCourse.TabIndex = 2;
            this.viewCourse.Text = "ViewCourse";
            this.viewCourse.UseVisualStyleBackColor = true;
            this.viewCourse.Click += new System.EventHandler(this.viewCourse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.viewCourse_Click);
            // 
            // AcademicAffairMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewCourse);
            this.Controls.Add(this.viewClass);
            this.Controls.Add(this.label1);
            this.Name = "AcademicAffairMainForm";
            this.Text = "AcademicAffairMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewClass;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewCourse;
        private System.Windows.Forms.Button button1;
    }
}