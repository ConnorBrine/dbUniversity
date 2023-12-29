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
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBUniversityFullDataSet1 = new The_amazing_of_numbers.DBUniversityFullDataSet1();
            this.classTableAdapter = new The_amazing_of_numbers.DBUniversityFullDataSet1TableAdapters.ClassTableAdapter();
            this.dBUniversityUpdate2DataSet1 = new The_amazing_of_numbers.DBUniversityUpdate2DataSet1();
            this.classBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter1 = new The_amazing_of_numbers.DBUniversityUpdate2DataSet1TableAdapters.ClassTableAdapter();
            this.Info = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dBUniversityUpdateDataSet = new The_amazing_of_numbers.DBUniversityUpdateDataSet();
            this.academicAffairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academic_AffairTableAdapter = new The_amazing_of_numbers.DBUniversityUpdateDataSetTableAdapters.Academic_AffairTableAdapter();
            this.dbEdit = new The_amazing_of_numbers.dbEdit();
            this.academic_AffairTableAdapter1 = new The_amazing_of_numbers.dbEditTableAdapters.Academic_AffairTableAdapter();
            this.tableAdapterManager = new The_amazing_of_numbers.dbEditTableAdapters.TableAdapterManager();
            this.classBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dBUniversityUpdate2DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBUniversityUpdate2DataSet2 = new The_amazing_of_numbers.DBUniversityUpdate2DataSet2();
            this.classBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter2 = new The_amazing_of_numbers.DBUniversityUpdate2DataSet2TableAdapters.ClassTableAdapter();
            this.infotxtbox = new System.Windows.Forms.RichTextBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new The_amazing_of_numbers.DBUniversityUpdate2DataSet2TableAdapters.DepartmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityFullDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityUpdate2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityUpdateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicAffairBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityUpdate2DataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityUpdate2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.dBUniversityFullDataSet1;
            // 
            // dBUniversityFullDataSet1
            // 
            this.dBUniversityFullDataSet1.DataSetName = "DBUniversityFullDataSet1";
            this.dBUniversityFullDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // dBUniversityUpdate2DataSet1
            // 
            this.dBUniversityUpdate2DataSet1.DataSetName = "DBUniversityUpdate2DataSet1";
            this.dBUniversityUpdate2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classBindingSource1
            // 
            this.classBindingSource1.DataMember = "Class";
            this.classBindingSource1.DataSource = this.dBUniversityUpdate2DataSet1;
            // 
            // classTableAdapter1
            // 
            this.classTableAdapter1.ClearBeforeFill = true;
            // 
            // Info
            // 
            this.Info.DataPropertyName = "class_id";
            this.Info.HeaderText = "Infomation";
            this.Info.MinimumWidth = 6;
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Info});
            this.dataGridView1.Location = new System.Drawing.Point(60, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dBUniversityUpdateDataSet
            // 
            this.dBUniversityUpdateDataSet.DataSetName = "DBUniversityUpdateDataSet";
            this.dBUniversityUpdateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // academicAffairBindingSource
            // 
            this.academicAffairBindingSource.DataMember = "Academic_Affair";
            this.academicAffairBindingSource.DataSource = this.dBUniversityUpdateDataSet;
            // 
            // academic_AffairTableAdapter
            // 
            this.academic_AffairTableAdapter.ClearBeforeFill = true;
            // 
            // dbEdit
            // 
            this.dbEdit.DataSetName = "dbEdit";
            this.dbEdit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // academic_AffairTableAdapter1
            // 
            this.academic_AffairTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Academic_AffairTableAdapter = this.academic_AffairTableAdapter1;
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.AdminTestTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.LectureRegisClassTableAdapter = null;
            this.tableAdapterManager.LectureTableAdapter = null;
            this.tableAdapterManager.LectureVioTableAdapter = null;
            this.tableAdapterManager.OpenClassTableAdapter = null;
            this.tableAdapterManager.PractiseScoreTableAdapter = null;
            this.tableAdapterManager.StudentRegisClassTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.StudentVioTableAdapter = null;
            this.tableAdapterManager.Subject_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = The_amazing_of_numbers.dbEditTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.ViolateTableAdapter = null;
            // 
            // classBindingSource3
            // 
            this.classBindingSource3.DataMember = "Class";
            this.classBindingSource3.DataSource = this.dBUniversityUpdate2DataSet2BindingSource;
            // 
            // dBUniversityUpdate2DataSet2BindingSource
            // 
            this.dBUniversityUpdate2DataSet2BindingSource.DataSource = this.dBUniversityUpdate2DataSet2;
            this.dBUniversityUpdate2DataSet2BindingSource.Position = 0;
            // 
            // dBUniversityUpdate2DataSet2
            // 
            this.dBUniversityUpdate2DataSet2.DataSetName = "DBUniversityUpdate2DataSet2";
            this.dBUniversityUpdate2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classBindingSource2
            // 
            this.classBindingSource2.DataMember = "Class";
            this.classBindingSource2.DataSource = this.dBUniversityUpdate2DataSet2;
            // 
            // classTableAdapter2
            // 
            this.classTableAdapter2.ClearBeforeFill = true;
            // 
            // infotxtbox
            // 
            this.infotxtbox.Location = new System.Drawing.Point(60, 322);
            this.infotxtbox.Name = "infotxtbox";
            this.infotxtbox.Size = new System.Drawing.Size(504, 245);
            this.infotxtbox.TabIndex = 1;
            this.infotxtbox.Text = "";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.dBUniversityUpdate2DataSet2BindingSource;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // viewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 612);
            this.Controls.Add(this.infotxtbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewClass";
            this.Text = "viewClass";
            this.Load += new System.EventHandler(this.viewClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityFullDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityUpdate2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityUpdateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicAffairBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityUpdate2DataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityUpdate2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DBUniversityFullDataSet1 dBUniversityFullDataSet1;
        private System.Windows.Forms.BindingSource classBindingSource;
        private DBUniversityFullDataSet1TableAdapters.ClassTableAdapter classTableAdapter;
        private DBUniversityUpdate2DataSet1 dBUniversityUpdate2DataSet1;
        private System.Windows.Forms.BindingSource classBindingSource1;
        private DBUniversityUpdate2DataSet1TableAdapters.ClassTableAdapter classTableAdapter1;
        private DBUniversityUpdate2DataSet2 dBUniversityUpdate2DataSet2;
        private System.Windows.Forms.BindingSource classBindingSource2;
        private DBUniversityUpdate2DataSet2TableAdapters.ClassTableAdapter classTableAdapter2;
        private System.Windows.Forms.DataGridViewButtonColumn Info;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBUniversityUpdateDataSet dBUniversityUpdateDataSet;
        private System.Windows.Forms.BindingSource academicAffairBindingSource;
        private DBUniversityUpdateDataSetTableAdapters.Academic_AffairTableAdapter academic_AffairTableAdapter;
        private System.Windows.Forms.BindingSource dBUniversityUpdate2DataSet2BindingSource;
        private dbEdit dbEdit;
        private dbEditTableAdapters.Academic_AffairTableAdapter academic_AffairTableAdapter1;
        private dbEditTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource classBindingSource3;
        private System.Windows.Forms.RichTextBox infotxtbox;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DBUniversityUpdate2DataSet2TableAdapters.DepartmentTableAdapter departmentTableAdapter;
    }
}