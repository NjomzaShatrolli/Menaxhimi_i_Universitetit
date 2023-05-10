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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            cmbDepartment.DisplayMember = "Department_Name";
            cmbDepartment.ValueMember = "Department_Id";
        }

        private void BtnSaveStud_Click(object sender, EventArgs e)
        {
            var selectedDepartment = (Department)cmbDepartment.SelectedItem;
            StudentBLL.VerifyData(txtStudName.Text, txtStudEmail.Text, txtStudPhone.Text, txtStudAdd.Text, txtStudGender.Text, dtpStudB.Value, selectedDepartment.Department_Id);
            BindData();
            Reset();
        }
  
        private void BtnUpdateStud_Click(object sender, EventArgs e)
        {
            var selectedDepartment = (Department)cmbDepartment.SelectedItem;
            StudentBLL.VerifyToUpdateData(ID, txtStudName.Text, txtStudEmail.Text, txtStudPhone.Text, txtStudAdd.Text, txtStudGender.Text, dtpStudB.Value, selectedDepartment.Department_Id);
            BindData();
            Reset();
        }

        private void BtnDeleteStud_Click(object sender, EventArgs e)
        {
            StudentBLL.VerifyToDelete(ID);
            BindData();
            Reset();
        } 
      
        private int ID;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtStudName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStudEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStudPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtStudAdd.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtStudGender.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpStudB.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[6].Value;
            cmbDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            var departments = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.GetDepartment, null).ToDepartmentList();
            departments.Insert(0, new Department { Department_Id = 0, Department_Name = "Select a department" });
            cmbDepartment.DataSource = departments;
            BindData();
        }

        public void BindData()
        {
            studentBindingSource.DataSource = StudentBLL.LoadData();
        }

        private void Reset()
        {
            txtStudName.Text = "";
            txtStudEmail.Text = "";
            txtStudPhone.Text = "";
            txtStudAdd.Text = "";
            txtStudGender.Text = "";
            dtpStudB.Value = DateTime.Now;
            cmbDepartment.Text = "Select a department";
        }

        private void HomeP_lbl_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
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

        private void Class_lbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class cla = new Class();
            cla.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login1 = new Login();
            login1.Show();
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
