using StudentPerformanceTracker.studentData;
using StudentPerformanceTracker.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentPerformanceTracker
{
    public partial class SignIn : Form
    {
        public TextBox tb_studentName;
        public SignIn()
        {
            InitializeComponent();
            tb_studentName = studentName_tb;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yh_Click(object sender, EventArgs e)
        {

        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            tb_studentName = studentName_tb;
            StudentData.studentName = studentName_tb.Text;
            Console.WriteLine("Student In " + studentName_tb.Text);
            this.Hide();
            Subjects subjects = new Subjects();
            subjects.Show();

            

        }
    }
}
