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
    public static class DAClass
    {
        public static List<Class> ToClassList(this DataTable table)
        {
            var classes = new List<Class>();

            foreach (DataRow row in table.Rows)
            {
                var class_ = new Class()
                {
                    Class_Id = Convert.ToInt32(row["class_id"]),
                    Semester = Convert.ToString(row["semester"]),
                    Year = Convert.ToInt32(row["year"]),
                    Start_Time = Convert.ToDateTime(row["start_time"]),
                    End_Time = Convert.ToDateTime(row["end_time"]),
                    Room_Number = Convert.ToString(row["room_number"]),
                    Course_Id = Convert.ToInt32(row["course_id"]),
                    Prof_Id = Convert.ToInt32(row["prof_id"]),
                };

                classes.Add(class_);
            }

            return classes;
        }

        public static void SaveData(string Semester, int Year, DateTime StartT, DateTime EndT, string RoomId, int CourseId, int ProfId)
        {
            var parameters = new[]
            {
                    new SqlParameter("@semester", SqlDbType.VarChar) { Value = Semester },
                    new SqlParameter("@year", SqlDbType.Int) { Value = Year },
                    new SqlParameter("@start_time", SqlDbType.Date){ Value = StartT},
                    new SqlParameter("@end_time", SqlDbType.Date){ Value = EndT},
                    new SqlParameter("@room_number", SqlDbType.VarChar){ Value = RoomId},
                    new SqlParameter("@course_id", SqlDbType.Int){ Value = CourseId},
                    new SqlParameter("@prof_id", SqlDbType.Int){ Value = ProfId},
            };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateClass, parameters);

            MessageBox.Show("Class Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void UpdateData(int id, string Semester, int Year, DateTime StartT, DateTime EndT, string RoomId, int CourseId, int ProfId)
        {
            var parameters = new[]
            {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = id },
                    new SqlParameter("@semester", SqlDbType.VarChar) { Value = Semester },
                    new SqlParameter("@year", SqlDbType.Int) { Value = Year },
                    new SqlParameter("@start_time", SqlDbType.Date){ Value = StartT},
                    new SqlParameter("@end_time", SqlDbType.Date){ Value = EndT},
                    new SqlParameter("@room_number", SqlDbType.VarChar){ Value = RoomId},
                    new SqlParameter("@course_id", SqlDbType.Int){ Value = CourseId},
                    new SqlParameter("@prof_id", SqlDbType.Int){ Value = ProfId},
            };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateClass, parameters);

            MessageBox.Show("Record Updated Successfully!");
        }

        public static void DeleteData(int id)
        {
            var parameters = new[]
            {
                new SqlParameter("@ID", SqlDbType.Int) { Value = id }
            };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteClass, parameters);

            MessageBox.Show("Record Deleted Successfully!");
        }
    }
}
