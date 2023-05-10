namespace TI_project
{
    partial class Course
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCreditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCourseDesc = new System.Windows.Forms.TextBox();
            this.BtnUpdateCourse = new System.Windows.Forms.Button();
            this.BtnDeleteCourse = new System.Windows.Forms.Button();
            this.BtnSaveCourse = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCourseCreds = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LogOut_lbl = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.Class_lbl = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Dep_lbl = new System.Windows.Forms.Label();
            this.Faculty_lbl = new System.Windows.Forms.Label();
            this.Stud_lbl = new System.Windows.Forms.Label();
            this.Home_lbl = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmbLang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.courseTitleDataGridViewTextBoxColumn,
            this.courseDescriptionDataGridViewTextBoxColumn,
            this.courseCreditsDataGridViewTextBoxColumn,
            this.departmentIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "Course_Id";
            resources.ApplyResources(this.courseIdDataGridViewTextBoxColumn, "courseIdDataGridViewTextBoxColumn");
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            // 
            // courseTitleDataGridViewTextBoxColumn
            // 
            this.courseTitleDataGridViewTextBoxColumn.DataPropertyName = "Course_Title";
            resources.ApplyResources(this.courseTitleDataGridViewTextBoxColumn, "courseTitleDataGridViewTextBoxColumn");
            this.courseTitleDataGridViewTextBoxColumn.Name = "courseTitleDataGridViewTextBoxColumn";
            // 
            // courseDescriptionDataGridViewTextBoxColumn
            // 
            this.courseDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Course_Description";
            resources.ApplyResources(this.courseDescriptionDataGridViewTextBoxColumn, "courseDescriptionDataGridViewTextBoxColumn");
            this.courseDescriptionDataGridViewTextBoxColumn.Name = "courseDescriptionDataGridViewTextBoxColumn";
            // 
            // courseCreditsDataGridViewTextBoxColumn
            // 
            this.courseCreditsDataGridViewTextBoxColumn.DataPropertyName = "Course_Credits";
            resources.ApplyResources(this.courseCreditsDataGridViewTextBoxColumn, "courseCreditsDataGridViewTextBoxColumn");
            this.courseCreditsDataGridViewTextBoxColumn.Name = "courseCreditsDataGridViewTextBoxColumn";
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "Department_Id";
            resources.ApplyResources(this.departmentIdDataGridViewTextBoxColumn, "departmentIdDataGridViewTextBoxColumn");
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(TI_Project.BO.Course);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            resources.ApplyResources(this.cmbDepartment, "cmbDepartment");
            this.cmbDepartment.Name = "cmbDepartment";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtCourseDesc
            // 
            resources.ApplyResources(this.txtCourseDesc, "txtCourseDesc");
            this.txtCourseDesc.Name = "txtCourseDesc";
            // 
            // BtnUpdateCourse
            // 
            resources.ApplyResources(this.BtnUpdateCourse, "BtnUpdateCourse");
            this.BtnUpdateCourse.Name = "BtnUpdateCourse";
            this.BtnUpdateCourse.UseVisualStyleBackColor = true;
            this.BtnUpdateCourse.Click += new System.EventHandler(this.BtnUpdateCourse_Click);
            // 
            // BtnDeleteCourse
            // 
            resources.ApplyResources(this.BtnDeleteCourse, "BtnDeleteCourse");
            this.BtnDeleteCourse.Name = "BtnDeleteCourse";
            this.BtnDeleteCourse.UseVisualStyleBackColor = true;
            this.BtnDeleteCourse.Click += new System.EventHandler(this.BtnDeleteCourse_Click);
            // 
            // BtnSaveCourse
            // 
            resources.ApplyResources(this.BtnSaveCourse, "BtnSaveCourse");
            this.BtnSaveCourse.Name = "BtnSaveCourse";
            this.BtnSaveCourse.UseVisualStyleBackColor = true;
            this.BtnSaveCourse.Click += new System.EventHandler(this.BtnSaveCourse_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtCourseCreds
            // 
            resources.ApplyResources(this.txtCourseCreds, "txtCourseCreds");
            this.txtCourseCreds.Name = "txtCourseCreds";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtCourseTitle
            // 
            resources.ApplyResources(this.txtCourseTitle, "txtCourseTitle");
            this.txtCourseTitle.Name = "txtCourseTitle";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // LogOut_lbl
            // 
            resources.ApplyResources(this.LogOut_lbl, "LogOut_lbl");
            this.LogOut_lbl.Name = "LogOut_lbl";
            this.LogOut_lbl.Click += new System.EventHandler(this.LogOut_lbl_Click);
            // 
            // pictureBox11
            // 
            resources.ApplyResources(this.pictureBox11, "pictureBox11");
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.TabStop = false;
            // 
            // Class_lbl
            // 
            resources.ApplyResources(this.Class_lbl, "Class_lbl");
            this.Class_lbl.Name = "Class_lbl";
            this.Class_lbl.Click += new System.EventHandler(this.Class_lbl_Click);
            // 
            // pictureBox7
            // 
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // pictureBox6
            // 
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // Dep_lbl
            // 
            resources.ApplyResources(this.Dep_lbl, "Dep_lbl");
            this.Dep_lbl.Name = "Dep_lbl";
            this.Dep_lbl.Click += new System.EventHandler(this.Dep_lbl_Click);
            // 
            // Faculty_lbl
            // 
            resources.ApplyResources(this.Faculty_lbl, "Faculty_lbl");
            this.Faculty_lbl.Name = "Faculty_lbl";
            this.Faculty_lbl.Click += new System.EventHandler(this.Faculty_lbl_Click);
            // 
            // Stud_lbl
            // 
            resources.ApplyResources(this.Stud_lbl, "Stud_lbl");
            this.Stud_lbl.Name = "Stud_lbl";
            this.Stud_lbl.Click += new System.EventHandler(this.Stud_lbl_Click);
            // 
            // Home_lbl
            // 
            resources.ApplyResources(this.Home_lbl, "Home_lbl");
            this.Home_lbl.Name = "Home_lbl";
            this.Home_lbl.Click += new System.EventHandler(this.Home_lbl_Click);
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label14);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 19;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cmbLang
            // 
            this.cmbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLang.FormattingEnabled = true;
            this.cmbLang.Items.AddRange(new object[] {
            resources.GetString("cmbLang.Items"),
            resources.GetString("cmbLang.Items1")});
            resources.ApplyResources(this.cmbLang, "cmbLang");
            this.cmbLang.Name = "cmbLang";
            this.cmbLang.SelectedIndexChanged += new System.EventHandler(this.cmbLang_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Course
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbLang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCourseDesc);
            this.Controls.Add(this.BtnUpdateCourse);
            this.Controls.Add(this.BtnDeleteCourse);
            this.Controls.Add(this.BtnSaveCourse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCourseCreds);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.LogOut_lbl);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.Class_lbl);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Dep_lbl);
            this.Controls.Add(this.Faculty_lbl);
            this.Controls.Add(this.Stud_lbl);
            this.Controls.Add(this.Home_lbl);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCourseDesc;
        private System.Windows.Forms.Button BtnUpdateCourse;
        private System.Windows.Forms.Button BtnDeleteCourse;
        private System.Windows.Forms.Button BtnSaveCourse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCourseCreds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LogOut_lbl;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label Class_lbl;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label Dep_lbl;
        private System.Windows.Forms.Label Faculty_lbl;
        private System.Windows.Forms.Label Stud_lbl;
        private System.Windows.Forms.Label Home_lbl;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ComboBox cmbLang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCreditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
    }
}