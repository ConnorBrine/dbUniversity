namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    partial class viewClass
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
            this.dBUniversityFullDataSet1 = new The_amazing_of_numbers.DBUniversityFullDataSet1();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new The_amazing_of_numbers.DBUniversityFullDataSet1TableAdapters.ClassTableAdapter();
            this.Info = new System.Windows.Forms.DataGridViewButtonColumn();
            this.classidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionstartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityFullDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Info,
            this.classidDataGridViewTextBoxColumn,
            this.datestartDataGridViewTextBoxColumn,
            this.dateendDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.daysDataGridViewTextBoxColumn,
            this.sectionstartDataGridViewTextBoxColumn,
            this.sectionendDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.classBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dBUniversityFullDataSet1
            // 
            this.dBUniversityFullDataSet1.DataSetName = "DBUniversityFullDataSet1";
            this.dBUniversityFullDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.dBUniversityFullDataSet1;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // Info
            // 
            this.Info.DataPropertyName = "class_id";
            this.Info.HeaderText = "Infomation";
            this.Info.MinimumWidth = 6;
            this.Info.Name = "Info";
            this.Info.Width = 125;
            // 
            // classidDataGridViewTextBoxColumn
            // 
            this.classidDataGridViewTextBoxColumn.DataPropertyName = "class_id";
            this.classidDataGridViewTextBoxColumn.HeaderText = "class_id";
            this.classidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classidDataGridViewTextBoxColumn.Name = "classidDataGridViewTextBoxColumn";
            this.classidDataGridViewTextBoxColumn.Width = 125;
            // 
            // datestartDataGridViewTextBoxColumn
            // 
            this.datestartDataGridViewTextBoxColumn.DataPropertyName = "date_start";
            this.datestartDataGridViewTextBoxColumn.HeaderText = "date_start";
            this.datestartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datestartDataGridViewTextBoxColumn.Name = "datestartDataGridViewTextBoxColumn";
            this.datestartDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateendDataGridViewTextBoxColumn
            // 
            this.dateendDataGridViewTextBoxColumn.DataPropertyName = "date_end";
            this.dateendDataGridViewTextBoxColumn.HeaderText = "date_end";
            this.dateendDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateendDataGridViewTextBoxColumn.Name = "dateendDataGridViewTextBoxColumn";
            this.dateendDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "room";
            this.roomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // daysDataGridViewTextBoxColumn
            // 
            this.daysDataGridViewTextBoxColumn.DataPropertyName = "days_";
            this.daysDataGridViewTextBoxColumn.HeaderText = "days_";
            this.daysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daysDataGridViewTextBoxColumn.Name = "daysDataGridViewTextBoxColumn";
            this.daysDataGridViewTextBoxColumn.Width = 125;
            // 
            // sectionstartDataGridViewTextBoxColumn
            // 
            this.sectionstartDataGridViewTextBoxColumn.DataPropertyName = "section_start";
            this.sectionstartDataGridViewTextBoxColumn.HeaderText = "section_start";
            this.sectionstartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectionstartDataGridViewTextBoxColumn.Name = "sectionstartDataGridViewTextBoxColumn";
            this.sectionstartDataGridViewTextBoxColumn.Width = 125;
            // 
            // sectionendDataGridViewTextBoxColumn
            // 
            this.sectionendDataGridViewTextBoxColumn.DataPropertyName = "section_end";
            this.sectionendDataGridViewTextBoxColumn.HeaderText = "section_end";
            this.sectionendDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sectionendDataGridViewTextBoxColumn.Name = "sectionendDataGridViewTextBoxColumn";
            this.sectionendDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Department: ";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(109, 260);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 16);
            this.ID.TabIndex = 2;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(133, 293);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 16);
            this.username.TabIndex = 2;
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(166, 327);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(0, 16);
            this.Department.TabIndex = 2;
            // 
            // viewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 612);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.username);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewClass";
            this.Text = "viewClass";
            this.Load += new System.EventHandler(this.viewClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityFullDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DBUniversityFullDataSet1 dBUniversityFullDataSet1;
        private System.Windows.Forms.BindingSource classBindingSource;
        private DBUniversityFullDataSet1TableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionstartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionendDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label Department;
    }
}