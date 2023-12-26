using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace The_amazing_of_numbers
{
    public partial class Button2 : Form
    {
        public Button2()
        {
            InitializeComponent();
        }

        private void Button2_Load(object sender, EventArgs e)
        {

        }
        private void lightdarkmodebtn_CheckedChanged(object sender, EventArgs e)
        {
            if (lightdarkmodebtn.Checked)
            {
                this.BackColor = Color.DimGray;
                DarkMode.ForeColor = Color.WhiteSmoke;
                label1.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
                DarkMode.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
