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
    public static class DACourse
    {
        public static List<Course> ToCourseList(this DataTable table)
        {
            var courses = new List<Course>();

            foreach (DataRow row in table.Rows)
            {
                var course = new Course()
                {
                    Course_Id = Convert.ToInt32(row["course_id"]),
                    Course_Title = Convert.ToString(row["course_title"]),
                    Course_Description = Convert.ToString(row["course_description"]),
                    Course_Credits = Convert.ToInt32(row["course_credits"]),
                    Department_Id = Convert.ToInt32(row["department_id"])
                };

                courses.Add(course);
            }

            return courses;
        }

        public static void SaveData(string CourseTitle, string CourseDesc, int CourseCreds, int DepId)
        {
            var parameters = new[]
            {
                    new SqlParameter("@course_title", SqlDbType.VarChar) { Value = CourseTitle },
                    new SqlParameter("@course_description", SqlDbType.VarChar) { Value = CourseDesc },
                    new SqlParameter("@course_credits", SqlDbType.Int){ Value = CourseCreds},
                    new SqlParameter("@department_id", SqlDbType.Int){ Value = DepId},
            };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateCourse, parameters);

            MessageBox.Show("Course Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void UpdateData(int id, string CourseTitle, string CourseDesc, int CourseCreds, int DepId)
        {
            var parameters = new[]
            {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = id },
                   new SqlParameter("@course_title", SqlDbType.VarChar) { Value = CourseTitle },
                    new SqlParameter("@course_description", SqlDbType.VarChar) { Value = CourseDesc },
                    new SqlParameter("@course_credits", SqlDbType.Int){ Value = CourseCreds},
                    new SqlParameter("@department_id", SqlDbType.Int){ Value = DepId},
            };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateCourse, parameters);

            MessageBox.Show("Record Updated Successfully!");
        }

        public static void DeleteData(int id)
        {
            var parameters = new[]
            {
                new SqlParameter("@ID", SqlDbType.Int) { Value = id }
            };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteCourse, parameters);

            MessageBox.Show("Record Deleted Successfully!");
        }
    }
}
