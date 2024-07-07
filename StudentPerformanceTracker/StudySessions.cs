using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentPerformanceTracker.studentData;

namespace StudentPerformanceTracker
{
    public partial class StudySessions : Form
    {
        public StudySessions()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Breaks breaks = new Breaks();
            breaks.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects subjects = new Subjects();
            subjects.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void StudySessions_Load(object sender, EventArgs e)
        {
            studentName_lbl.Text = "Student Name : " + studentData.StudentData.studentName ;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide() ;   
            Reports reports = new Reports();    
            reports.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
