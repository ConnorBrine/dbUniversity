using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using The_amazing_of_numbers.Model;
using System.Data.SqlClient;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class viewClass : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6GJCG8P;Initial Catalog=DBUniversityUpdate2;Integrated Security=True");
        dbUniversityDataContext db = new dbUniversityDataContext();
        User cur_user;
        public viewClass()
        {
            InitializeComponent();
        }
        public viewClass(User cur_user)
        {
            InitializeComponent();
            this.cur_user = cur_user;
            Academic_Affair aa = db.Academic_Affairs.Where(x => x.id == cur_user.id).FirstOrDefault();
           
        }

        private void viewClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBUniversityUpdate2DataSet2.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dBUniversityUpdate2DataSet2.Department);


            String query = "SELECT Class.class_id AS [Class ID], OpenClass.course_id AS[Course ID], Subject_.course_name AS[Course Name], " +
                           "Lecture.name_ AS Lecture, Lecture.id AS[Lecture ID], Class.room AS Room, Class.capacity AS Capacity, Class.days_ AS Days," +
                           "Lecture.status_ AS Lecture_Status, Subject_.department_id AS Department, LectureRegisClass.status_ AS Class_Status "+
                           "FROM     Class INNER JOIN OpenClass ON Class.class_id = OpenClass.class_id " +
                           "INNER JOIN LectureRegisClass ON Class.class_id = LectureRegisClass.class_id " +
                           "INNER JOIN Lecture ON LectureRegisClass.id = Lecture.id " +
                           "INNER JOIN Subject_ ON OpenClass.course_id = Subject_.course_id " +
                           "ORDER BY [Class ID]";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow info = dataGridView1.Rows[e.RowIndex];
                infotxtbox.Text = "Class ID: " + info.Cells[1].Value +
                "\nCourse ID: " + info.Cells[2].Value +
                "\nCourse Name: " + info.Cells[3].Value +
                "\nLecture: " + info.Cells[4].Value +
                "\nLecture ID: " + info.Cells[5].Value +
                "\nRoom: " + info.Cells[6].Value +
                "\nCapacity: " + info.Cells[7].Value +
                "\nDays: " + info.Cells[8].Value +
                "\nLecture Status: " + info.Cells[9].Value +
                "\nDepartment ID: " + info.Cells[10].Value +
                "\nClass Status: " + info.Cells[11].Value;
            }
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.academic_AffairTableAdapter1.FillBy(this.dbEdit.Academic_Affair);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.classTableAdapter2.FillBy(this.dBUniversityUpdate2DataSet2.Class);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.classTableAdapter2.FillBy1(this.dBUniversityUpdate2DataSet2.Class);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.classTableAdapter2.FillBy2(this.dBUniversityUpdate2DataSet2.Class);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.classTableAdapter2.FillBy1(this.dBUniversityUpdate2DataSet2.Class);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
