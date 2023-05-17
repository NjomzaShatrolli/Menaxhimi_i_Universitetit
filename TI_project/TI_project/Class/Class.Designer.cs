namespace TI_project
{
    partial class Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.classIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.BtnUpdateClass = new System.Windows.Forms.Button();
            this.BtnDeleteClass = new System.Windows.Forms.Button();
            this.BtnSaveClass = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Course_lbl = new System.Windows.Forms.Label();
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
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbProf = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmbLang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
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
            this.classIdDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.courseIdDataGridViewTextBoxColumn,
            this.profIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.classBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // classIdDataGridViewTextBoxColumn
            // 
            this.classIdDataGridViewTextBoxColumn.DataPropertyName = "Class_Id";
            resources.ApplyResources(this.classIdDataGridViewTextBoxColumn, "classIdDataGridViewTextBoxColumn");
            this.classIdDataGridViewTextBoxColumn.Name = "classIdDataGridViewTextBoxColumn";
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            resources.ApplyResources(this.semesterDataGridViewTextBoxColumn, "semesterDataGridViewTextBoxColumn");
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            resources.ApplyResources(this.yearDataGridViewTextBoxColumn, "yearDataGridViewTextBoxColumn");
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "Start_Time";
            resources.ApplyResources(this.startTimeDataGridViewTextBoxColumn, "startTimeDataGridViewTextBoxColumn");
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "End_Time";
            resources.ApplyResources(this.endTimeDataGridViewTextBoxColumn, "endTimeDataGridViewTextBoxColumn");
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "Room_Number";
            resources.ApplyResources(this.roomNumberDataGridViewTextBoxColumn, "roomNumberDataGridViewTextBoxColumn");
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "Course_Id";
            resources.ApplyResources(this.courseIdDataGridViewTextBoxColumn, "courseIdDataGridViewTextBoxColumn");
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            // 
            // profIdDataGridViewTextBoxColumn
            // 
            this.profIdDataGridViewTextBoxColumn.DataPropertyName = "Prof_Id";
            resources.ApplyResources(this.profIdDataGridViewTextBoxColumn, "profIdDataGridViewTextBoxColumn");
            this.profIdDataGridViewTextBoxColumn.Name = "profIdDataGridViewTextBoxColumn";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(TI_Project.BO.Class);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Items.AddRange(new object[] {
            resources.GetString("cmbRoom.Items"),
            resources.GetString("cmbRoom.Items1"),
            resources.GetString("cmbRoom.Items2"),
            resources.GetString("cmbRoom.Items3"),
            resources.GetString("cmbRoom.Items4")});
            resources.ApplyResources(this.cmbRoom, "cmbRoom");
            this.cmbRoom.Name = "cmbRoom";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtYear
            // 
            resources.ApplyResources(this.txtYear, "txtYear");
            this.txtYear.Name = "txtYear";
            // 
            // BtnUpdateClass
            // 
            resources.ApplyResources(this.BtnUpdateClass, "BtnUpdateClass");
            this.BtnUpdateClass.Name = "BtnUpdateClass";
            this.BtnUpdateClass.UseVisualStyleBackColor = true;
            this.BtnUpdateClass.Click += new System.EventHandler(this.BtnUpdateClass_Click);
            // 
            // BtnDeleteClass
            // 
            resources.ApplyResources(this.BtnDeleteClass, "BtnDeleteClass");
            this.BtnDeleteClass.Name = "BtnDeleteClass";
            this.BtnDeleteClass.UseVisualStyleBackColor = true;
            this.BtnDeleteClass.Click += new System.EventHandler(this.BtnDeleteClass_Click);
            // 
            // BtnSaveClass
            // 
            resources.ApplyResources(this.BtnSaveClass, "BtnSaveClass");
            this.BtnSaveClass.Name = "BtnSaveClass";
            this.BtnSaveClass.UseVisualStyleBackColor = true;
            this.BtnSaveClass.Click += new System.EventHandler(this.BtnSaveClass_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // LogOut
            // 
            resources.ApplyResources(this.LogOut, "LogOut");
            this.LogOut.Name = "LogOut";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // pictureBox11
            // 
            resources.ApplyResources(this.pictureBox11, "pictureBox11");
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // pictureBox7
            // 
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // Course_lbl
            // 
            resources.ApplyResources(this.Course_lbl, "Course_lbl");
            this.Course_lbl.Name = "Course_lbl";
            this.Course_lbl.Click += new System.EventHandler(this.Course_lbl_Click);
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
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            resources.GetString("cmbSemester.Items"),
            resources.GetString("cmbSemester.Items1"),
            resources.GetString("cmbSemester.Items2"),
            resources.GetString("cmbSemester.Items3"),
            resources.GetString("cmbSemester.Items4"),
            resources.GetString("cmbSemester.Items5")});
            resources.ApplyResources(this.cmbSemester, "cmbSemester");
            this.cmbSemester.Name = "cmbSemester";
            // 
            // dtpStart
            // 
            resources.ApplyResources(this.dtpStart, "dtpStart");
            this.dtpStart.Name = "dtpStart";
            // 
            // dtpEnd
            // 
            resources.ApplyResources(this.dtpEnd, "dtpEnd");
            this.dtpEnd.Name = "dtpEnd";
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FormattingEnabled = true;
            resources.ApplyResources(this.cmbCourse, "cmbCourse");
            this.cmbCourse.Name = "cmbCourse";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // cmbProf
            // 
            this.cmbProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProf.FormattingEnabled = true;
            resources.ApplyResources(this.cmbProf, "cmbProf");
            this.cmbProf.Name = "cmbProf";
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
            // Class
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbLang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProf);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.BtnUpdateClass);
            this.Controls.Add(this.BtnDeleteClass);
            this.Controls.Add(this.BtnSaveClass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.Course_lbl);
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
            this.Name = "Class";
            this.Load += new System.EventHandler(this.Class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button BtnUpdateClass;
        private System.Windows.Forms.Button BtnDeleteClass;
        private System.Windows.Forms.Button BtnSaveClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label Course_lbl;
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
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbProf;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.ComboBox cmbLang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profIdDataGridViewTextBoxColumn;
    }
}