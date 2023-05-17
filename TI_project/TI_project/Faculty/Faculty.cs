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
    public partial class Faculty : Form
    {
        public Faculty()
        {
            InitializeComponent();
            cmbDepartment.DisplayMember = "Department_Name";
            cmbDepartment.ValueMember = "Department_Id";
        } 
        
        private void BtnSaveProf_Click(object sender, EventArgs e)
        {
            var selectedDepartment = (Department)cmbDepartment.SelectedItem;
            FacultyBLL.VerifyData(txt_ProfName.Text, txt_ProfEmail.Text, txt_ProfPhone.Text, txt_ProfAdd.Text, txt_ProfGender.Text, selectedDepartment.Department_Id);
            BindData();
            Reset();
        }

        private void BtnUpdateProf_Click(object sender, EventArgs e)
        {
            var selectedDepartment = (Department)cmbDepartment.SelectedItem;
            FacultyBLL.VerifyToUpdateData(ID, txt_ProfName.Text, txt_ProfEmail.Text, txt_ProfPhone.Text, txt_ProfAdd.Text, txt_ProfGender.Text, selectedDepartment.Department_Id);
            BindData();
            Reset();
        }

        private void BtnDeleteProf_Click(object sender, EventArgs e)
        {
            FacultyBLL.Delete(ID);
            BindData();
            Reset();
        }

        private int ID;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_ProfName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ProfEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_ProfPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_ProfAdd.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_ProfGender.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        private void Faculty_Load(object sender, EventArgs e)
        {
            var departments = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.GetDepartment, null).ToDepartmentList();
            departments.Insert(0, new Department { Department_Id = 0, Department_Name = "Select a department" });
            cmbDepartment.DataSource = departments;
            BindData();
        }

        public void BindData()
        {
            facultyBindingSource.DataSource = FacultyBLL.LoadData();
        }

        private void Reset()
        {
            txt_ProfName.Text = "";
            txt_ProfEmail.Text = "";
            txt_ProfPhone.Text = "";
            txt_ProfAdd.Text = "";
            txt_ProfGender.Text = "";
            cmbDepartment.Text = "Select a department";
        }

        private void Homep_lbl_Click(object sender, EventArgs e)
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

        private void Class_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class cla = new Class();
            cla.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
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
