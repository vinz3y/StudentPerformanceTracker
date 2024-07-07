using StudentPerformanceTracker.models;
using StudentPerformanceTracker.studentData;
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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            try
            {
                DataTable subjectTbl = new DataTable();
                subjectTbl.Columns.Add("Subjects", typeof(string));
                if (StudentData.subjectsData.Count > 0 && StudentData.subjectsData != null)
                {
                    foreach (Subject sub in studentData.StudentData.subjectsData)
                    {
                        subjectTbl.Rows.Add(sub.SubjectName);
                    }
                    dataGridView1.DataSource = subjectTbl;

                }
                else
                {

                    MessageBox.Show("No existing records for Subjects.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = subjectTbl;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void create_sub_btn_Click(object sender, EventArgs e)
        {
            Subject newSubject = new Subject(new_subject_txt.Text);

            try
            {
                StudentData.subjectsData.Add(newSubject);
                loadData();
                new_subject_txt.Clear();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error : Couldn't Create Subject!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new_subject_txt.Clear();
            }

        }

        private void delete_sub_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Subject toBeDeletedSub = StudentData.subjectsData.FirstOrDefault(recorded_sub => recorded_sub.SubjectName.Equals(new_subject_txt.Text, StringComparison.OrdinalIgnoreCase));

                if (toBeDeletedSub != null)
                {
                    StudentData.subjectsData.Remove(toBeDeletedSub);
                    loadData();
                    new_subject_txt.Clear();
                    MessageBox.Show("Subject deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Subject not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error : Couldn't Delete Subject!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new_subject_txt.Clear();
            }
            

        }
    }
}
