using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI_Project.DAL;
using TIProject.BLL;
using TI_Project.DAL.Helpers;
using System.Data.SqlClient;
using System.Threading;

namespace TI_project
{
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
            cmbCourse.DisplayMember = "Course_Title";
            cmbCourse.ValueMember = "Course_Id";
            cmbProf.DisplayMember = "Prof_Name";
            cmbProf.ValueMember = "Prof_Id";
        }

        private void BtnSaveClass_Click(object sender, EventArgs e)
        {
            var selectedCourse = (TI_Project.BO.Course)cmbCourse.SelectedItem;
            var selectedProf = (TI_Project.BO.Faculty)cmbProf.SelectedItem;

            ClassBLL.VerifyData(cmbSemester.Text, int.Parse(txtYear.Text), dtpStart.Value, dtpEnd.Value, cmbRoom.Text, selectedCourse.Course_Id, selectedProf.Prof_Id);
            BindData();
            Reset();
        }

        private void BtnUpdateClass_Click(object sender, EventArgs e)
        {
            var selectedCourse = (TI_Project.BO.Course)cmbCourse.SelectedItem;
            var selectedProf = (TI_Project.BO.Faculty)cmbProf.SelectedItem;

            ClassBLL.VerifyToUpdateData(ID, cmbSemester.Text, int.Parse(txtYear.Text), dtpStart.Value, dtpEnd.Value, cmbRoom.Text, selectedCourse.Course_Id, selectedProf.Prof_Id);
            BindData();
            Reset();
        }

        private void BtnDeleteClass_Click(object sender, EventArgs e)
        {
            ClassBLL.VerifyToDelete(ID);
            BindData();
            Reset();
        }

        private void Class_Load(object sender, EventArgs e)
        {
            var courses = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.GetCourse, null).ToCourseList();
            courses.Insert(0, new TI_Project.BO.Course { Course_Id = 0, Course_Title = "Select a Course" });
            cmbCourse.DataSource = courses;
            BindData();

            var faculty = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.GetFaculty, null).ToFacultyList();
            faculty.Insert(0, new TI_Project.BO.Faculty { Prof_Id = 0, Prof_Name = "Select the Professor" }) ;
            cmbProf.DataSource = faculty;
            BindData();

            Reset();

        }

        private int ID;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmbSemester.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtYear.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            dtpStart.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            dtpEnd.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
            cmbRoom.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbCourse.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbProf.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        public void BindData()
        {
            classBindingSource.DataSource = ClassBLL.LoadData();
        }

        private void Reset()
        {
            cmbSemester.Text = null;
            txtYear.Text = "";
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            cmbRoom.Text = null;
            cmbCourse.Text = null;
            cmbProf.Text = null;
        }

        private void cmbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbLang.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("sq");
                    break;
            }

            this.Controls.Clear();
            InitializeComponent();
            BindData();
        }

        private void Home_lbl_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        private void Stud_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students stu = new Students();
            stu.Show();
        }

        private void Faculty_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Faculty f = new Faculty();
            f.Show();
        }

        private void Dep_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department_ dep = new Department_();
            dep.Show();
        }

        private void Course_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Course c = new Course();
            c.Show();
        }
        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

    }
}
