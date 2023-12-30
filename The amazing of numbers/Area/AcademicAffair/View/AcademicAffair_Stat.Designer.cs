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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBUniversityUpdate2DataSet2 = new The_amazing_of_numbers.DBUniversityUpdate2DataSet2();
            this.stu_yearcmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.top10btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.studentTableAdapter = new The_amazing_of_numbers.DBUniversityUpdate2DataSet2TableAdapters.StudentTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totcredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learning_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.training_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfViolations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityUpdate2DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.schoolyearDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.totcredDataGridViewTextBoxColumn,
            this.learning_score,
            this.training_score,
            this.numOfViolations});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1461, 572);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.dBUniversityUpdate2DataSet2;
            // 
            // dBUniversityUpdate2DataSet2
            // 
            this.dBUniversityUpdate2DataSet2.DataSetName = "DBUniversityUpdate2DataSet2";
            this.dBUniversityUpdate2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stu_yearcmb
            // 
            this.stu_yearcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.label2.Location = new System.Drawing.Point(388, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Learning Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(831, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Violation";
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tăng dần",
            "Giảm dần"});
            this.comboBox1.Location = new System.Drawing.Point(452, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Tag = "1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.checkAsc_or_Desc);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name_";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name_";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolyearDataGridViewTextBoxColumn
            // 
            this.schoolyearDataGridViewTextBoxColumn.DataPropertyName = "school_year";
            this.schoolyearDataGridViewTextBoxColumn.HeaderText = "school_year";
            this.schoolyearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.schoolyearDataGridViewTextBoxColumn.Name = "schoolyearDataGridViewTextBoxColumn";
            this.schoolyearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totcredDataGridViewTextBoxColumn
            // 
            this.totcredDataGridViewTextBoxColumn.DataPropertyName = "tot_cred";
            this.totcredDataGridViewTextBoxColumn.HeaderText = "tot_cred";
            this.totcredDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totcredDataGridViewTextBoxColumn.Name = "totcredDataGridViewTextBoxColumn";
            this.totcredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // learning_score
            // 
            this.learning_score.DataPropertyName = "learning_score";
            this.learning_score.HeaderText = "learning_score";
            this.learning_score.MinimumWidth = 6;
            this.learning_score.Name = "learning_score";
            this.learning_score.ReadOnly = true;
            // 
            // training_score
            // 
            this.training_score.DataPropertyName = "training_score";
            this.training_score.HeaderText = "traning_score";
            this.training_score.MinimumWidth = 6;
            this.training_score.Name = "training_score";
            this.training_score.ReadOnly = true;
            // 
            // numOfViolations
            // 
            this.numOfViolations.DataPropertyName = "numOfViolations";
            this.numOfViolations.HeaderText = "numOfViolations";
            this.numOfViolations.MinimumWidth = 6;
            this.numOfViolations.Name = "numOfViolations";
            this.numOfViolations.ReadOnly = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Tăng dần",
            "Giảm dần"});
            this.comboBox2.Location = new System.Drawing.Point(701, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(110, 24);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Tag = "2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.checkAsc_or_Desc);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Tăng dần",
            "Giảm dần"});
            this.comboBox3.Location = new System.Drawing.Point(905, 41);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(110, 24);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.Tag = "3";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.checkAsc_or_Desc);
            // 
            // AcademicAffair_Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 684);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.top10btn);
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
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityUpdate2DataSet2)).EndInit();
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
        private System.Windows.Forms.Button top10btn;
        private DBUniversityUpdate2DataSet2 dBUniversityUpdate2DataSet2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DBUniversityUpdate2DataSet2TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totcredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn learning_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn training_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfViolations;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}