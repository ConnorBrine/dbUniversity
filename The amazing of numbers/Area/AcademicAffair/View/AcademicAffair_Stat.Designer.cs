namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    partial class AcademicAffair_Stat
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stu_yearcmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.u1 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.u2 = new System.Windows.Forms.Button();
            this.u3 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.top10btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // stu_yearcmb
            // 
            this.stu_yearcmb.FormattingEnabled = true;
            this.stu_yearcmb.Items.AddRange(new object[] {
            "All",
            "1",
            "2",
            "3",
            "4"});
            this.stu_yearcmb.Location = new System.Drawing.Point(173, 46);
            this.stu_yearcmb.Name = "stu_yearcmb";
            this.stu_yearcmb.Size = new System.Drawing.Size(80, 24);
            this.stu_yearcmb.TabIndex = 1;
            this.stu_yearcmb.SelectedIndexChanged += new System.EventHandler(this.stu_yearcmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn sinh viên năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Learning Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(814, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Violent";
            // 
            // u1
            // 
            this.u1.Location = new System.Drawing.Point(381, 12);
            this.u1.Name = "u1";
            this.u1.Size = new System.Drawing.Size(57, 23);
            this.u1.TabIndex = 3;
            this.u1.Tag = "1";
            this.u1.Text = "up";
            this.u1.UseVisualStyleBackColor = true;
            this.u1.Click += new System.EventHandler(this.Ascending);
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(381, 46);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(57, 23);
            this.d1.TabIndex = 3;
            this.d1.Tag = "1";
            this.d1.Text = "down";
            this.d1.UseVisualStyleBackColor = true;
            this.d1.Click += new System.EventHandler(this.Descending);
            // 
            // u2
            // 
            this.u2.Location = new System.Drawing.Point(624, 12);
            this.u2.Name = "u2";
            this.u2.Size = new System.Drawing.Size(57, 23);
            this.u2.TabIndex = 3;
            this.u2.Tag = "2";
            this.u2.Text = "up";
            this.u2.UseVisualStyleBackColor = true;
            this.u2.Click += new System.EventHandler(this.Ascending);
            // 
            // u3
            // 
            this.u3.Location = new System.Drawing.Point(868, 12);
            this.u3.Name = "u3";
            this.u3.Size = new System.Drawing.Size(57, 23);
            this.u3.TabIndex = 3;
            this.u3.Tag = "3";
            this.u3.Text = "up";
            this.u3.UseVisualStyleBackColor = true;
            this.u3.Click += new System.EventHandler(this.Ascending);
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(625, 46);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(57, 23);
            this.d2.TabIndex = 3;
            this.d2.Tag = "2";
            this.d2.Text = "down";
            this.d2.UseVisualStyleBackColor = true;
            this.d2.Click += new System.EventHandler(this.Descending);
            // 
            // d3
            // 
            this.d3.Location = new System.Drawing.Point(868, 47);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(57, 23);
            this.d3.TabIndex = 3;
            this.d3.Tag = "3";
            this.d3.Text = "down";
            this.d3.UseVisualStyleBackColor = true;
            this.d3.Click += new System.EventHandler(this.Descending);
            // 
            // top10btn
            // 
            this.top10btn.Location = new System.Drawing.Point(1041, 11);
            this.top10btn.Name = "top10btn";
            this.top10btn.Size = new System.Drawing.Size(180, 54);
            this.top10btn.TabIndex = 4;
            this.top10btn.Text = "Top 10";
            this.top10btn.UseVisualStyleBackColor = true;
            this.top10btn.Click += new System.EventHandler(this.top10btn_Click);
            // 
            // AcademicAffair_Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 684);
            this.Controls.Add(this.top10btn);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.u3);
            this.Controls.Add(this.u2);
            this.Controls.Add(this.u1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stu_yearcmb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AcademicAffair_Stat";
            this.Text = "AcademicAffair_Stat";
            this.Load += new System.EventHandler(this.AcademicAffair_Stat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox stu_yearcmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button u1;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button u2;
        private System.Windows.Forms.Button u3;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button top10btn;
    }
}