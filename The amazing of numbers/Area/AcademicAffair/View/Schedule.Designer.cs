namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    partial class Schedule
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
            this.cmbyear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columncmb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_dgv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBUniversityUpdateDataSet = new The_amazing_of_numbers.DBUniversityUpdateDataSet();
            this.subject_TableAdapter = new The_amazing_of_numbers.DBUniversityUpdateDataSetTableAdapters.Subject_TableAdapter();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.searchtxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.semestercmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchBtn1 = new System.Windows.Forms.Button();
            this.className = new System.Windows.Forms.Label();
            this.classescmb = new System.Windows.Forms.ComboBox();
            this.fromcmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.ComboBox();
            this.option2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.generatebtn = new System.Windows.Forms.Button();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infotxtbox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityUpdateDataSet)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbyear
            // 
            this.cmbyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbyear.FormattingEnabled = true;
            this.cmbyear.Items.AddRange(new object[] {
            "Year 1",
            "Year 2",
            "Year 3",
            "Year 4"});
            this.cmbyear.Location = new System.Drawing.Point(99, 69);
            this.cmbyear.Name = "cmbyear";
            this.cmbyear.Size = new System.Drawing.Size(121, 24);
            this.cmbyear.TabIndex = 10;
            this.cmbyear.SelectedIndexChanged += new System.EventHandler(this.cmbstudent_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Option";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // columncmb
            // 
            this.columncmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columncmb.FormattingEnabled = true;
            this.columncmb.Items.AddRange(new object[] {
            "IT",
            "Math",
            "Practice",
            "Bonus",
            "DP",
            "TA",
            "PE"});
            this.columncmb.Location = new System.Drawing.Point(352, 69);
            this.columncmb.Name = "columncmb";
            this.columncmb.Size = new System.Drawing.Size(121, 24);
            this.columncmb.TabIndex = 10;
            this.columncmb.SelectedIndexChanged += new System.EventHandler(this.cmbsemester_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_dgv,
            this.courseidDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.departmentidDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.subjectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 200);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_dgv
            // 
            this.btn_dgv.FillWeight = 40F;
            this.btn_dgv.HeaderText = "Choose";
            this.btn_dgv.MinimumWidth = 6;
            this.btn_dgv.Name = "btn_dgv";
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "course_id";
            this.courseidDataGridViewTextBoxColumn.FillWeight = 87.91444F;
            this.courseidDataGridViewTextBoxColumn.HeaderText = "course_id";
            this.courseidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "course_name";
            this.coursenameDataGridViewTextBoxColumn.FillWeight = 87.91444F;
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "course_name";
            this.coursenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn.FillWeight = 87.91444F;
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "department_id";
            this.departmentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "credits";
            this.creditsDataGridViewTextBoxColumn.FillWeight = 87.91444F;
            this.creditsDataGridViewTextBoxColumn.HeaderText = "credits";
            this.creditsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.FillWeight = 87.91444F;
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject_";
            this.subjectBindingSource.DataSource = this.dBUniversityUpdateDataSet;
            // 
            // dBUniversityUpdateDataSet
            // 
            this.dBUniversityUpdateDataSet.DataSetName = "DBUniversityUpdateDataSet";
            this.dBUniversityUpdateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subject_TableAdapter
            // 
            this.subject_TableAdapter.ClearBeforeFill = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(839, 59);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(128, 42);
            this.SearchBtn.TabIndex = 13;
            this.SearchBtn.Text = "Filter";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // searchtxtbox
            // 
            this.searchtxtbox.Location = new System.Drawing.Point(139, 26);
            this.searchtxtbox.Name = "searchtxtbox";
            this.searchtxtbox.Size = new System.Drawing.Size(225, 22);
            this.searchtxtbox.TabIndex = 15;
            this.searchtxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Course Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // semestercmb
            // 
            this.semestercmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semestercmb.FormattingEnabled = true;
            this.semestercmb.Items.AddRange(new object[] {
            "1A",
            "1B",
            "2A",
            "2B"});
            this.semestercmb.Location = new System.Drawing.Point(681, 66);
            this.semestercmb.Name = "semestercmb";
            this.semestercmb.Size = new System.Drawing.Size(121, 24);
            this.semestercmb.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Choose Semester";
            // 
            // searchBtn1
            // 
            this.searchBtn1.Location = new System.Drawing.Point(385, 16);
            this.searchBtn1.Name = "searchBtn1";
            this.searchBtn1.Size = new System.Drawing.Size(128, 42);
            this.searchBtn1.TabIndex = 13;
            this.searchBtn1.Text = "Search";
            this.searchBtn1.UseVisualStyleBackColor = true;
            this.searchBtn1.Click += new System.EventHandler(this.searchBtn1_Click);
            // 
            // className
            // 
            this.className.AutoSize = true;
            this.className.Location = new System.Drawing.Point(970, 9);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(44, 16);
            this.className.TabIndex = 19;
            this.className.Text = "label3";
            // 
            // classescmb
            // 
            this.classescmb.FormattingEnabled = true;
            this.classescmb.Location = new System.Drawing.Point(1792, 604);
            this.classescmb.Name = "classescmb";
            this.classescmb.Size = new System.Drawing.Size(94, 24);
            this.classescmb.TabIndex = 20;
            this.classescmb.Visible = false;
            // 
            // fromcmb
            // 
            this.fromcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromcmb.FormattingEnabled = true;
            this.fromcmb.Location = new System.Drawing.Point(2046, 672);
            this.fromcmb.Name = "fromcmb";
            this.fromcmb.Size = new System.Drawing.Size(94, 24);
            this.fromcmb.TabIndex = 20;
            this.fromcmb.Visible = false;
            this.fromcmb.SelectedIndexChanged += new System.EventHandler(this.fromcmb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2016, 653);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "from";
            this.label4.Visible = false;
            // 
            // option1
            // 
            this.option1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option1.FormattingEnabled = true;
            this.option1.Location = new System.Drawing.Point(1869, 620);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(94, 24);
            this.option1.TabIndex = 20;
            this.option1.Visible = false;
            this.option1.SelectedIndexChanged += new System.EventHandler(this.option1_SelectedIndexChanged);
            // 
            // option2
            // 
            this.option2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.option2.FormattingEnabled = true;
            this.option2.Location = new System.Drawing.Point(1869, 725);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(94, 24);
            this.option2.TabIndex = 20;
            this.option2.Visible = false;
            this.option2.SelectedIndexChanged += new System.EventHandler(this.option2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1866, 592);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Days in week";
            this.label8.Visible = false;
            // 
            // generatebtn
            // 
            this.generatebtn.Location = new System.Drawing.Point(1020, 245);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(347, 66);
            this.generatebtn.TabIndex = 22;
            this.generatebtn.Text = "Generate";
            this.generatebtn.UseVisualStyleBackColor = true;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(1923, 629);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.ReadOnly = true;
            this.txtbox1.Size = new System.Drawing.Size(167, 22);
            this.txtbox1.TabIndex = 24;
            this.txtbox1.Visible = false;
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(1923, 692);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.ReadOnly = true;
            this.txtbox2.Size = new System.Drawing.Size(167, 22);
            this.txtbox2.TabIndex = 24;
            this.txtbox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1096, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 29);
            this.label9.TabIndex = 29;
            this.label9.Text = "T7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(917, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 29);
            this.label10.TabIndex = 30;
            this.label10.Text = "T6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(718, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 29);
            this.label11.TabIndex = 31;
            this.label11.Text = "T5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(537, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 29);
            this.label12.TabIndex = 32;
            this.label12.Text = "T4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(341, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 29);
            this.label13.TabIndex = 33;
            this.label13.Text = "T3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(160, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 29);
            this.label14.TabIndex = 34;
            this.label14.Text = "T2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 112);
            this.panel2.TabIndex = 0;
            this.panel2.Tag = "C1T2";
            this.panel2.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(190, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 112);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "C1T3";
            this.panel1.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(377, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 112);
            this.panel4.TabIndex = 0;
            this.panel4.Tag = "C1T4";
            this.panel4.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(564, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 112);
            this.panel3.TabIndex = 0;
            this.panel3.Tag = "C1T5";
            this.panel3.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(751, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(181, 112);
            this.panel6.TabIndex = 0;
            this.panel6.Tag = "C1T6";
            this.panel6.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(1125, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(181, 112);
            this.panel5.TabIndex = 0;
            this.panel5.Tag = "C1T8";
            this.panel5.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel21);
            this.flowLayoutPanel1.Controls.Add(this.panel20);
            this.flowLayoutPanel1.Controls.Add(this.panel19);
            this.flowLayoutPanel1.Controls.Add(this.panel18);
            this.flowLayoutPanel1.Controls.Add(this.panel17);
            this.flowLayoutPanel1.Controls.Add(this.panel16);
            this.flowLayoutPanel1.Controls.Add(this.panel15);
            this.flowLayoutPanel1.Controls.Add(this.panel28);
            this.flowLayoutPanel1.Controls.Add(this.panel27);
            this.flowLayoutPanel1.Controls.Add(this.panel26);
            this.flowLayoutPanel1.Controls.Add(this.panel25);
            this.flowLayoutPanel1.Controls.Add(this.panel24);
            this.flowLayoutPanel1.Controls.Add(this.panel23);
            this.flowLayoutPanel1.Controls.Add(this.panel22);
            this.flowLayoutPanel1.Controls.Add(this.panel13);
            this.flowLayoutPanel1.Controls.Add(this.panel12);
            this.flowLayoutPanel1.Controls.Add(this.panel11);
            this.flowLayoutPanel1.Controls.Add(this.panel10);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Controls.Add(this.panel14);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(82, 365);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1310, 474);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Location = new System.Drawing.Point(938, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(181, 112);
            this.panel7.TabIndex = 0;
            this.panel7.Tag = "C1T7";
            this.panel7.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.LightGray;
            this.panel21.Location = new System.Drawing.Point(3, 121);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(181, 112);
            this.panel21.TabIndex = 0;
            this.panel21.Tag = "C2T2";
            this.panel21.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.LightGray;
            this.panel20.Location = new System.Drawing.Point(190, 121);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(181, 112);
            this.panel20.TabIndex = 0;
            this.panel20.Tag = "C2T3";
            this.panel20.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.LightGray;
            this.panel19.Location = new System.Drawing.Point(377, 121);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(181, 112);
            this.panel19.TabIndex = 0;
            this.panel19.Tag = "C2T4";
            this.panel19.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.LightGray;
            this.panel18.Location = new System.Drawing.Point(564, 121);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(181, 112);
            this.panel18.TabIndex = 0;
            this.panel18.Tag = "C2T5";
            this.panel18.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.LightGray;
            this.panel17.Location = new System.Drawing.Point(751, 121);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(181, 112);
            this.panel17.TabIndex = 0;
            this.panel17.Tag = "C2T6";
            this.panel17.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.LightGray;
            this.panel16.Location = new System.Drawing.Point(938, 121);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(181, 112);
            this.panel16.TabIndex = 0;
            this.panel16.Tag = "C2T7";
            this.panel16.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.LightGray;
            this.panel15.Location = new System.Drawing.Point(1125, 121);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(181, 112);
            this.panel15.TabIndex = 0;
            this.panel15.Tag = "C2T8";
            this.panel15.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.LightGray;
            this.panel28.Location = new System.Drawing.Point(3, 239);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(181, 112);
            this.panel28.TabIndex = 0;
            this.panel28.Tag = "C3T2";
            this.panel28.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.LightGray;
            this.panel27.Location = new System.Drawing.Point(190, 239);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(181, 112);
            this.panel27.TabIndex = 0;
            this.panel27.Tag = "C3T3";
            this.panel27.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.LightGray;
            this.panel26.Location = new System.Drawing.Point(377, 239);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(181, 112);
            this.panel26.TabIndex = 0;
            this.panel26.Tag = "C3T4";
            this.panel26.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.LightGray;
            this.panel25.Location = new System.Drawing.Point(564, 239);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(181, 112);
            this.panel25.TabIndex = 0;
            this.panel25.Tag = "C3T5";
            this.panel25.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.LightGray;
            this.panel24.Location = new System.Drawing.Point(751, 239);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(181, 112);
            this.panel24.TabIndex = 0;
            this.panel24.Tag = "C3T6";
            this.panel24.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.LightGray;
            this.panel23.Location = new System.Drawing.Point(938, 239);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(181, 112);
            this.panel23.TabIndex = 0;
            this.panel23.Tag = "C3T7";
            this.panel23.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.LightGray;
            this.panel22.Location = new System.Drawing.Point(1125, 239);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(181, 112);
            this.panel22.TabIndex = 0;
            this.panel22.Tag = "C3T8";
            this.panel22.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.LightGray;
            this.panel13.Location = new System.Drawing.Point(3, 357);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(181, 112);
            this.panel13.TabIndex = 0;
            this.panel13.Tag = "C4T2";
            this.panel13.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.LightGray;
            this.panel12.Location = new System.Drawing.Point(190, 357);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(181, 112);
            this.panel12.TabIndex = 0;
            this.panel12.Tag = "C4T3";
            this.panel12.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightGray;
            this.panel11.Location = new System.Drawing.Point(377, 357);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(181, 112);
            this.panel11.TabIndex = 0;
            this.panel11.Tag = "C4T4";
            this.panel11.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightGray;
            this.panel10.Location = new System.Drawing.Point(564, 357);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(181, 112);
            this.panel10.TabIndex = 0;
            this.panel10.Tag = "C4T5";
            this.panel10.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.Location = new System.Drawing.Point(751, 357);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(181, 112);
            this.panel9.TabIndex = 0;
            this.panel9.Tag = "C4T6";
            this.panel9.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.LightGray;
            this.panel14.Location = new System.Drawing.Point(938, 357);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(181, 112);
            this.panel14.TabIndex = 0;
            this.panel14.Tag = "C4T7";
            this.panel14.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Location = new System.Drawing.Point(1125, 357);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(181, 112);
            this.panel8.TabIndex = 0;
            this.panel8.Tag = "C4T8";
            this.panel8.Click += new System.EventHandler(this.calender_OnClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 405);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 29);
            this.label15.TabIndex = 28;
            this.label15.Text = "Ca 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 522);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 29);
            this.label16.TabIndex = 28;
            this.label16.Text = "Ca 2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 638);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 29);
            this.label17.TabIndex = 28;
            this.label17.Text = "Ca 3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 755);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 29);
            this.label18.TabIndex = 28;
            this.label18.Text = "Ca 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1278, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "CN";
            // 
            // infotxtbox
            // 
            this.infotxtbox.Location = new System.Drawing.Point(973, 29);
            this.infotxtbox.Name = "infotxtbox";
            this.infotxtbox.ReadOnly = true;
            this.infotxtbox.Size = new System.Drawing.Size(236, 118);
            this.infotxtbox.TabIndex = 36;
            this.infotxtbox.Text = "";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 1055);
            this.Controls.Add(this.infotxtbox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.fromcmb);
            this.Controls.Add(this.classescmb);
            this.Controls.Add(this.className);
            this.Controls.Add(this.semestercmb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchtxtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.searchBtn1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.columncmb);
            this.Controls.Add(this.cmbyear);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityUpdateDataSet)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbyear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox columncmb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBUniversityUpdateDataSet dBUniversityUpdateDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private DBUniversityUpdateDataSetTableAdapters.Subject_TableAdapter subject_TableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn btn_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox searchtxtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox semestercmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchBtn1;
        private System.Windows.Forms.Label className;
        private System.Windows.Forms.ComboBox classescmb;
        private System.Windows.Forms.ComboBox fromcmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox option1;
        private System.Windows.Forms.ComboBox option2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox infotxtbox;
    }
}