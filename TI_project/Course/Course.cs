using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI_Project.BO;
using TI_Project.DAL;
using TIProject.BLL;
using TI_Project.DAL.Helpers;
using System.Data.SqlClient;
using System.Threading;

namespace TI_project
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
            cmbDepartment.DisplayMember = "Department_Name";
            cmbDepartment.ValueMember = "Department_Id";
        }
        
        private void BtnSaveCourse_Click(object sender, EventArgs e)
        {
            var selectedDepartment = (Department)cmbDepartment.SelectedItem;
            CourseBLL.VerifyData(txtCourseTitle.Text, txtCourseDesc.Text, int.Parse(txtCourseCreds.Text), selectedDepartment.Department_Id);
            BindData();
            Reset();

        }

        private void BtnUpdateCourse_Click(object sender, EventArgs e)
        {
            var selectedDepartment = (Department)cmbDepartment.SelectedItem;
            CourseBLL.VerifyToUpdate(ID, txtCourseTitle.Text, txtCourseDesc.Text, int.Parse(txtCourseCreds.Text), selectedDepartment.Department_Id);
            BindData();
            Reset(); 
        }

        private void BtnDeleteCourse_Click(object sender, EventArgs e)
        {
            CourseBLL.VerifyToDelete(ID);
            BindData();
            Reset();
            
        }

        private int ID;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCourseTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCourseDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCourseCreds.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void BindData()
        {
            courseBindingSource.DataSource = CourseBLL.LoadData();
        }

        private void Reset()
        {
            txtCourseTitle.Text = "";
            txtCourseDesc.Text = "";
            txtCourseCreds.Text = "";
            cmbDepartment.Text = "Select a department";
        }

        private void Course_Load(object sender, EventArgs e)
        {
            var departments = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.GetDepartment, null).ToDepartmentList();
            departments.Insert(0, new Department { Department_Id = 0, Department_Name = "Select a department"  });
            cmbDepartment.DataSource = departments;
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
            Students s = new Students();
            s.Show();
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

        private void Class_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class cla = new Class();
            cla.Show();
        }

        private void LogOut_lbl_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
            this.Hide();
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
    }
}
