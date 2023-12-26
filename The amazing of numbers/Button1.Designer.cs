namespace The_amazing_of_numbers
{
    partial class Button1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AllStudentBtn = new System.Windows.Forms.RadioButton();
            this.LectureBtn = new System.Windows.Forms.RadioButton();
            this.AcademicBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.StudentBtn = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBUniversityDataSet = new The_amazing_of_numbers.DBUniversityDataSet();
            this.AdminBtn = new System.Windows.Forms.RadioButton();
            this.dBUniversityDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new The_amazing_of_numbers.DBUniversityDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AllStudentBtn
            // 
            this.AllStudentBtn.AutoSize = true;
            this.AllStudentBtn.Location = new System.Drawing.Point(187, 50);
            this.AllStudentBtn.Name = "AllStudentBtn";
            this.AllStudentBtn.Size = new System.Drawing.Size(75, 20);
            this.AllStudentBtn.TabIndex = 0;
            this.AllStudentBtn.TabStop = true;
            this.AllStudentBtn.Text = "All User";
            this.AllStudentBtn.UseVisualStyleBackColor = true;
            this.AllStudentBtn.CheckedChanged += new System.EventHandler(this.AllStudentBtn_CheckedChanged);
            // 
            // LectureBtn
            // 
            this.LectureBtn.AutoSize = true;
            this.LectureBtn.Location = new System.Drawing.Point(251, 97);
            this.LectureBtn.Name = "LectureBtn";
            this.LectureBtn.Size = new System.Drawing.Size(72, 20);
            this.LectureBtn.TabIndex = 1;
            this.LectureBtn.TabStop = true;
            this.LectureBtn.Text = "Lecture";
            this.LectureBtn.UseVisualStyleBackColor = true;
            this.LectureBtn.CheckedChanged += new System.EventHandler(this.LectureBtn_CheckedChanged);
            // 
            // AcademicBtn
            // 
            this.AcademicBtn.AutoSize = true;
            this.AcademicBtn.Location = new System.Drawing.Point(301, 50);
            this.AcademicBtn.Name = "AcademicBtn";
            this.AcademicBtn.Size = new System.Drawing.Size(122, 20);
            this.AcademicBtn.TabIndex = 2;
            this.AcademicBtn.TabStop = true;
            this.AcademicBtn.Text = "Academic Affair";
            this.AcademicBtn.UseVisualStyleBackColor = true;
            this.AcademicBtn.CheckedChanged += new System.EventHandler(this.AcademicBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sort by:";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem2.Text = "iconMenuItem2";
            // 
            // StudentBtn
            // 
            this.StudentBtn.AutoSize = true;
            this.StudentBtn.Location = new System.Drawing.Point(393, 97);
            this.StudentBtn.Name = "StudentBtn";
            this.StudentBtn.Size = new System.Drawing.Size(73, 20);
            this.StudentBtn.TabIndex = 4;
            this.StudentBtn.TabStop = true;
            this.StudentBtn.Text = "Student";
            this.StudentBtn.UseVisualStyleBackColor = true;
            this.StudentBtn.CheckedChanged += new System.EventHandler(this.StudentBtn_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.pinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(99, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 255);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password_";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password_";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role_";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role_";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // pinDataGridViewTextBoxColumn
            // 
            this.pinDataGridViewTextBoxColumn.DataPropertyName = "pin";
            this.pinDataGridViewTextBoxColumn.HeaderText = "pin";
            this.pinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pinDataGridViewTextBoxColumn.Name = "pinDataGridViewTextBoxColumn";
            this.pinDataGridViewTextBoxColumn.Width = 125;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dBUniversityDataSet;
            // 
            // dBUniversityDataSet
            // 
            this.dBUniversityDataSet.DataSetName = "DBUniversityDataSet";
            this.dBUniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdminBtn
            // 
            this.AdminBtn.AutoSize = true;
            this.AdminBtn.Location = new System.Drawing.Point(461, 50);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(66, 20);
            this.AdminBtn.TabIndex = 6;
            this.AdminBtn.TabStop = true;
            this.AdminBtn.Text = "Admin";
            this.AdminBtn.UseVisualStyleBackColor = true;
            this.AdminBtn.CheckedChanged += new System.EventHandler(this.AdminBtn_CheckedChanged_1);
            // 
            // dBUniversityDataSetBindingSource
            // 
            this.dBUniversityDataSetBindingSource.DataSource = this.dBUniversityDataSet;
            this.dBUniversityDataSetBindingSource.Position = 0;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Button1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StudentBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcademicBtn);
            this.Controls.Add(this.LectureBtn);
            this.Controls.Add(this.AllStudentBtn);
            this.Name = "Button1";
            this.Text = "Button1";
            this.Load += new System.EventHandler(this.Button1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton AllStudentBtn;
        private System.Windows.Forms.RadioButton LectureBtn;
        private System.Windows.Forms.RadioButton AcademicBtn;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private System.Windows.Forms.RadioButton StudentBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dBUniversityDataSetBindingSource;
        private DBUniversityDataSet dBUniversityDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DBUniversityDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pinDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton AdminBtn;
    }
}