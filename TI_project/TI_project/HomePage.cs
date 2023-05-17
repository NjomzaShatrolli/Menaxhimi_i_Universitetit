using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_project
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
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
            switch(cmbLang.SelectedIndex)
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

        }
    }
}
