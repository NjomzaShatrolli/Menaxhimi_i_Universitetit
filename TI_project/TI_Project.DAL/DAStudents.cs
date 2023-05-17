using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI_Project.BO;
using TI_Project.DAL.Helpers;

namespace TI_Project.DAL
{
    public static class DAStudents
    {
        public static List<BO.Student> ToStudentList(this DataTable table)
        {
            var students = new List<BO.Student>();

            foreach (DataRow row in table.Rows)
            {
                var student = new BO.Student()
                {
                    Stud_Id = Convert.ToInt32(row["student_id"]),
                    Student_Name = Convert.ToString(row["student_name"]),
                    Student_Email = Convert.ToString(row["student_email"]),
                    Student_Phone = Convert.ToString(row["student_phone"]),
                    Student_Address = Convert.ToString(row["student_address"]),
                    Student_Gender = Convert.ToString(row["student_gender"]),
                    Student_Birthday = Convert.ToDateTime(row["date_of_birth"]),
                    Department_Id = Convert.ToInt32(row["department_id"])
                };

                students.Add(student);
            }

            return students;
        }

        public static void SaveData(string StudName, string StudEmail, string StudPhone, string StudAdd, string StudGender, DateTime StudBirthday, int DepId)
        {
            var parameters = new[]
                {
                    new SqlParameter("@student_name", SqlDbType.VarChar) { Value = StudName },
                    new SqlParameter("@student_email", SqlDbType.VarChar) { Value = StudEmail },
                    new SqlParameter("@student_phone", SqlDbType.VarChar){ Value = StudPhone},
                    new SqlParameter("@student_address", SqlDbType.VarChar){ Value = StudAdd},
                    new SqlParameter("@student_gender", SqlDbType.VarChar){ Value = StudGender},
                    new SqlParameter("@date_of_birth", SqlDbType.Date){ Value = StudBirthday},
                    new SqlParameter("@department_id", SqlDbType.Int){ Value = DepId},
            };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateStudent, parameters);

            MessageBox.Show("Student Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        public static void UpdateData(int id, string StudName, string StudEmail, string StudPhone, string StudAdd, string StudGender, DateTime StudBirthday, int DepId)
        {
            var parameters = new[]
                {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = id }, 
                    new SqlParameter("@student_name", SqlDbType.VarChar) { Value = StudName },
                    new SqlParameter("@student_email", SqlDbType.VarChar) { Value = StudEmail },
                    new SqlParameter("@student_phone", SqlDbType.VarChar){ Value = StudPhone},
                    new SqlParameter("@student_address", SqlDbType.VarChar){ Value = StudAdd},
                    new SqlParameter("@student_gender", SqlDbType.VarChar){ Value = StudGender},
                    new SqlParameter("@date_of_birth", SqlDbType.Date){ Value = StudBirthday},
                    new SqlParameter("@department_id", SqlDbType.Int){ Value = DepId},
            };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateStudent, parameters);

            MessageBox.Show("Record Updated Successfully!");
        }


        public static void DeleteData(int id)
        {
            var parameters = new[]
                {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = id }
                };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteStudent, parameters);

            MessageBox.Show("Record Deleted Successfully!");
        }
    }
}
