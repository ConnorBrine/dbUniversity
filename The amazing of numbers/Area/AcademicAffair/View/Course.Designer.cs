namespace The_amazing_of_numbers
{
    partial class Course
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
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.subjectBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dbEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEdit = new The_amazing_of_numbers.dbEdit();
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBUniversityUpdateDataSet = new The_amazing_of_numbers.DBUniversityUpdateDataSet();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBUniversityDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBUniversityDataSet = new The_amazing_of_numbers.DBUniversityDataSet();
            this.Infolbl = new System.Windows.Forms.Label();
            this.Info2lbl = new System.Windows.Forms.Label();
            this.numlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.subject_TableAdapter = new The_amazing_of_numbers.DBUniversityDataSetTableAdapters.Subject_TableAdapter();
            this.subject_TableAdapter1 = new The_amazing_of_numbers.DBUniversityUpdateDataSetTableAdapters.Subject_TableAdapter();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new The_amazing_of_numbers.DBUniversityUpdateDataSetTableAdapters.ClassTableAdapter();
            this.subjectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.dBUniversityFullDataSet = new The_amazing_of_numbers.DBUniversityFullDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new The_amazing_of_numbers.DBUniversityFullDataSetTableAdapters.StudentTableAdapter();
            this.classBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter1 = new The_amazing_of_numbers.dbEditTableAdapters.ClassTableAdapter();
            this.subject_TableAdapter2 = new The_amazing_of_numbers.dbEditTableAdapters.Subject_TableAdapter();
            this.SelectData = new System.Windows.Forms.Label();
            this.totCredit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totCred = new System.Windows.Forms.Label();
            this.costnum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.columncmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.listcourse_txtbox = new System.Windows.Forms.RichTextBox();
            this.semestercmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityUpdateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityFullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseidDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.departmentidDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.chk});
            this.dataGridView1.DataSource = this.subjectBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "course_id";
            this.courseidDataGridViewTextBoxColumn.HeaderText = "course_id";
            this.courseidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "course_name";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "course_name";
            this.coursenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "department_id";
            this.departmentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "credits";
            this.creditsDataGridViewTextBoxColumn.HeaderText = "credits";
            this.creditsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.MinimumWidth = 10;
            this.chk.Name = "chk";
            // 
            // subjectBindingSource3
            // 
            this.subjectBindingSource3.DataMember = "Subject_";
            this.subjectBindingSource3.DataSource = this.dbEditBindingSource;
            // 
            // dbEditBindingSource
            // 
            this.dbEditBindingSource.DataSource = this.dbEdit;
            this.dbEditBindingSource.Position = 0;
            // 
            // dbEdit
            // 
            this.dbEdit.DataSetName = "dbEdit";
            this.dbEdit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataMember = "Subject_";
            this.subjectBindingSource1.DataSource = this.dBUniversityUpdateDataSet;
            // 
            // dBUniversityUpdateDataSet
            // 
            this.dBUniversityUpdateDataSet.DataSetName = "DBUniversityUpdateDataSet";
            this.dBUniversityUpdateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject_";
            this.subjectBindingSource.DataSource = this.dBUniversityDataSetBindingSource;
            // 
            // dBUniversityDataSetBindingSource
            // 
            this.dBUniversityDataSetBindingSource.DataSource = this.dBUniversityDataSet;
            this.dBUniversityDataSetBindingSource.Position = 0;
            // 
            // dBUniversityDataSet
            // 
            this.dBUniversityDataSet.DataSetName = "DBUniversityDataSet";
            this.dBUniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Infolbl
            // 
            this.Infolbl.AutoSize = true;
            this.Infolbl.Location = new System.Drawing.Point(29, 541);
            this.Infolbl.Name = "Infolbl";
            this.Infolbl.Size = new System.Drawing.Size(82, 16);
            this.Infolbl.TabIndex = 1;
            this.Infolbl.Text = "You choose ";
            // 
            // Info2lbl
            // 
            this.Info2lbl.AutoSize = true;
            this.Info2lbl.Location = new System.Drawing.Point(147, 541);
            this.Info2lbl.Name = "Info2lbl";
            this.Info2lbl.Size = new System.Drawing.Size(57, 16);
            this.Info2lbl.TabIndex = 2;
            this.Info2lbl.Text = "Courses";
            // 
            // numlbl
            // 
            this.numlbl.AutoSize = true;
            this.numlbl.Location = new System.Drawing.Point(117, 541);
            this.numlbl.Name = "numlbl";
            this.numlbl.Size = new System.Drawing.Size(14, 16);
            this.numlbl.TabIndex = 3;
            this.numlbl.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // subject_TableAdapter
            // 
            this.subject_TableAdapter.ClearBeforeFill = true;
            // 
            // subject_TableAdapter1
            // 
            this.subject_TableAdapter1.ClearBeforeFill = true;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.dBUniversityUpdateDataSet;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // subjectBindingSource2
            // 
            this.subjectBindingSource2.DataMember = "Subject_";
            this.subjectBindingSource2.DataSource = this.dBUniversityDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(107, 502);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 16);
            this.username.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(290, 502);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 16);
            this.ID.TabIndex = 6;
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(562, 502);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(0, 16);
            this.Department.TabIndex = 6;
            // 
            // dBUniversityFullDataSet
            // 
            this.dBUniversityFullDataSet.DataSetName = "DBUniversityFullDataSet";
            this.dBUniversityFullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.dBUniversityFullDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // classBindingSource1
            // 
            this.classBindingSource1.DataMember = "Class";
            this.classBindingSource1.DataSource = this.dbEditBindingSource;
            // 
            // classTableAdapter1
            // 
            this.classTableAdapter1.ClearBeforeFill = true;
            // 
            // subject_TableAdapter2
            // 
            this.subject_TableAdapter2.ClearBeforeFill = true;
            // 
            // SelectData
            // 
            this.SelectData.AutoSize = true;
            this.SelectData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectData.Location = new System.Drawing.Point(27, 561);
            this.SelectData.Name = "SelectData";
            this.SelectData.Size = new System.Drawing.Size(89, 29);
            this.SelectData.TabIndex = 7;
            this.SelectData.Text = "All List:";
            // 
            // totCredit
            // 
            this.totCredit.AutoSize = true;
            this.totCredit.Location = new System.Drawing.Point(290, 541);
            this.totCredit.Name = "totCredit";
            this.totCredit.Size = new System.Drawing.Size(79, 16);
            this.totCredit.TabIndex = 8;
            this.totCredit.Text = "Total Credit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cost:";
            // 
            // totCred
            // 
            this.totCred.AutoSize = true;
            this.totCred.Location = new System.Drawing.Point(375, 541);
            this.totCred.Name = "totCred";
            this.totCred.Size = new System.Drawing.Size(0, 16);
            this.totCred.TabIndex = 8;
            // 
            // costnum
            // 
            this.costnum.AutoSize = true;
            this.costnum.Location = new System.Drawing.Point(525, 541);
            this.costnum.Name = "costnum";
            this.costnum.Size = new System.Drawing.Size(0, 16);
            this.costnum.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department ID";
            // 
            // columncmb
            // 
            this.columncmb.FormattingEnabled = true;
            this.columncmb.Location = new System.Drawing.Point(128, 27);
            this.columncmb.Name = "columncmb";
            this.columncmb.Size = new System.Drawing.Size(121, 24);
            this.columncmb.TabIndex = 9;
            this.columncmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(378, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(218, 43);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(8, 8);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // listcourse_txtbox
            // 
            this.listcourse_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listcourse_txtbox.Location = new System.Drawing.Point(32, 593);
            this.listcourse_txtbox.Name = "listcourse_txtbox";
            this.listcourse_txtbox.ReadOnly = true;
            this.listcourse_txtbox.Size = new System.Drawing.Size(932, 185);
            this.listcourse_txtbox.TabIndex = 13;
            this.listcourse_txtbox.Text = "";
            // 
            // semestercmb
            // 
            this.semestercmb.FormattingEnabled = true;
            this.semestercmb.Items.AddRange(new object[] {
            "1A",
            "1B",
            "2A",
            "2B"});
            this.semestercmb.Location = new System.Drawing.Point(169, 793);
            this.semestercmb.Name = "semestercmb";
            this.semestercmb.Size = new System.Drawing.Size(121, 24);
            this.semestercmb.TabIndex = 9;
            this.semestercmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 796);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Choose Semester";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(345, 787);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(583, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(345, 837);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(583, 71);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 837);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Note: all list above will be added to the \r\nclass, choose carefully";
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 963);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listcourse_txtbox);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.semestercmb);
            this.Controls.Add(this.columncmb);
            this.Controls.Add(this.costnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totCred);
            this.Controls.Add(this.totCredit);
            this.Controls.Add(this.SelectData);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numlbl);
            this.Controls.Add(this.Info2lbl);
            this.Controls.Add(this.Infolbl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Course";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityUpdateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityFullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dBUniversityDataSetBindingSource;
        private DBUniversityDataSet dBUniversityDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private DBUniversityDataSetTableAdapters.Subject_TableAdapter subject_TableAdapter;
        private System.Windows.Forms.Label Infolbl;
        private System.Windows.Forms.Label Info2lbl;
        private System.Windows.Forms.Label numlbl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.Button button1;
        private DBUniversityUpdateDataSet dBUniversityUpdateDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource1;
        private DBUniversityUpdateDataSetTableAdapters.Subject_TableAdapter subject_TableAdapter1;
        private System.Windows.Forms.BindingSource classBindingSource;
        private DBUniversityUpdateDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.BindingSource subjectBindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Department;
        private DBUniversityFullDataSet dBUniversityFullDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DBUniversityFullDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource dbEditBindingSource;
        private dbEdit dbEdit;
        private System.Windows.Forms.BindingSource classBindingSource1;
        private dbEditTableAdapters.ClassTableAdapter classTableAdapter1;
        private System.Windows.Forms.BindingSource subjectBindingSource3;
        private dbEditTableAdapters.Subject_TableAdapter subject_TableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label SelectData;
        private System.Windows.Forms.Label totCredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totCred;
        private System.Windows.Forms.Label costnum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox columncmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.RichTextBox listcourse_txtbox;
        private System.Windows.Forms.ComboBox semestercmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
    }
}