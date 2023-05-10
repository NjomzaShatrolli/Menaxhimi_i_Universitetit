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
    public partial class Department_ : Form
    {
        public Department_()
        {
            InitializeComponent();
        }

        private void Department__Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void SaveDepBtn_Click(object sender, EventArgs e)
        {
            DepartmentBLL.VerifyData(txt_DepName.Text, txt_DepDesc.Text);
            BindData();
            txt_DepName.Text = "";
            txt_DepDesc.Text = "";
        }

        private void EditDepBtn_Click(object sender, EventArgs e)
        {
            DepartmentBLL.VerifyToUpdateData(ID, txt_DepName.Text, txt_DepDesc.Text);
            BindData();
            txt_DepName.Text = "";
            txt_DepDesc.Text = "";
        }

        private void DeleteDepBtn_Click(object sender, EventArgs e)
        {
            DepartmentBLL.VerifyToDelete(ID);
            BindData();
            txt_DepName.Text = "";
            txt_DepDesc.Text = "";
        }
    
        private int ID;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the value from the selected row from the first cell
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_DepName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_DepDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        public void BindData()
        {
            departmentBindingSource.DataSource = DepartmentBLL.LoadData();
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

        private void LogOut_lbl_Click(object sender, EventArgs e)
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
