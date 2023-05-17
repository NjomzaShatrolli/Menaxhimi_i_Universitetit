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
    public static class DAFaculty
    {
        public static List<Faculty> ToFacultyList(this DataTable table)
        {
            var faculties = new List<Faculty>();

            foreach (DataRow row in table.Rows)
            {
                var faculty = new Faculty()
                {
                    Prof_Id = Convert.ToInt32(row["prof_id"]),
                    Prof_Name = Convert.ToString(row["prof_name"]),
                    Prof_Email = Convert.ToString(row["prof_email"]),
                    Prof_Phone = Convert.ToString(row["prof_phone"]),
                    Prof_Address = Convert.ToString(row["prof_address"]),
                    Prof_Gender = Convert.ToString(row["prof_gender"]),
                    Department_Id = Convert.ToInt32(row["department_id"])
                };

                faculties.Add(faculty);
            }

            return faculties;
        }

        public static void SaveData(string ProfName, string ProfEmail, string ProfPhone, string ProfAdd, string ProfGender, int DepId)
        {
            var parameters = new[]
            {
                    new SqlParameter("@prof_name", SqlDbType.VarChar) { Value = ProfName },
                    new SqlParameter("@prof_email", SqlDbType.VarChar) { Value = ProfEmail },
                    new SqlParameter("@prof_phone", SqlDbType.VarChar){ Value = ProfPhone},
                    new SqlParameter("@prof_address", SqlDbType.VarChar){ Value = ProfAdd},
                    new SqlParameter("@prof_gender", SqlDbType.VarChar){ Value = ProfGender},
                    new SqlParameter("@department_id", SqlDbType.Int){ Value = DepId},
            };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateFaculty, parameters);

            MessageBox.Show("Faculty Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void UpdateData(int id, string ProfName, string ProfEmail, string ProfPhone, string ProfAdd, string ProfGender, int DepId)
        {
            var parameters = new[]
            {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = id },
                    new SqlParameter("@prof_name", SqlDbType.VarChar) { Value = ProfName },
                    new SqlParameter("@prof_email", SqlDbType.VarChar) { Value = ProfEmail },
                    new SqlParameter("@prof_phone", SqlDbType.VarChar){ Value = ProfPhone},
                    new SqlParameter("@prof_address", SqlDbType.VarChar){ Value = ProfAdd},
                    new SqlParameter("@prof_gender", SqlDbType.VarChar){ Value = ProfGender},
                    new SqlParameter("@department_id", SqlDbType.Int){ Value = DepId},
            };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateFaculty, parameters);

            MessageBox.Show("Record Updated Successfully!");
        }

        public static void DeleteData(int id)
        {
            var parameters = new[]
            {
                new SqlParameter("@ID", SqlDbType.Int) { Value = id }
            };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteFaculty, parameters);

            MessageBox.Show("Record Deleted Successfully!");
        }

    }
}
