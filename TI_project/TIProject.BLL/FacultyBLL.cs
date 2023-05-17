using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI_Project.BO;
using TI_Project.DAL;
using TI_Project.DAL.Helpers;

namespace TIProject.BLL
{
    public static class FacultyBLL
    {
        public static object LoadData()
        {
            var faculties = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.GetFaculty, null).ToFacultyList();
            return faculties;
        }

        public static void VerifyData(string ProfName, string ProfEmail, string ProfPhone, string ProfAdd, string ProfGender, int DepId)
        {
            if (ProfName == null || ProfEmail == null || ProfPhone == null || ProfAdd == null || ProfGender == null || DepId == 0)
            {
                MessageBox.Show("Please Fill All Enteries!");
                return;
            }

            if (!VerifyProfEmail(ProfEmail))
            {
                MessageBox.Show("Please check your Email!");
                return;
            }

            if (!VerifyProfGender(ProfGender))
            {
                MessageBox.Show("The input on Gender was incorrect!");
                return;
            }

            DAFaculty.SaveData(ProfName, ProfEmail, ProfPhone, ProfAdd, ProfGender, DepId);
        }

        public static void VerifyToUpdateData(int id, string ProfName, string ProfEmail, string ProfPhone, string ProfAdd, string ProfGender, int DepId)
        {
            if (id == 0 || ProfName == null || ProfEmail == null || ProfPhone == null || ProfAdd == null || ProfGender == null || DepId == 0)
            {
                MessageBox.Show("Please Select Record To Update!");
                return;
            }

            if (!VerifyProfEmail(ProfEmail))
            {
                MessageBox.Show("Please check your Email!");
                return;
            }

            if (!VerifyProfGender(ProfGender))
            {
                MessageBox.Show("The input on Gender was incorrect!");
                return;
            }

            DAFaculty.UpdateData(id, ProfName, ProfEmail, ProfPhone, ProfAdd, ProfGender, DepId);

        }

        public static void Delete(int id)
        {
            if (id != 0)
            {
                DeleteClassByProfId(id);
                DAFaculty.DeleteData(id);
            }
            else
            {
                MessageBox.Show("Please Select Record To Delete!");
            }
        }

        private static void DeleteClassByProfId(int prof_id)
        {
            var parameters = new[]
            {
                new SqlParameter("@prof_id", SqlDbType.Int) { Value = prof_id }
            };

            DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteClassByProfId, parameters);
        }

        public static bool VerifyProfEmail(string profEmail)
        {
            if (!profEmail.Contains("@gmail.com") && !profEmail.Contains("@hotmail.com"))
            {
                return false;
            }

            return true;
        }

        public static bool VerifyProfGender(string profGender)
        {
            if (!profGender.Contains("Female") && !profGender.Contains("Male") && !profGender.Contains("F") && !profGender.Contains("M")
                && !profGender.Contains("Femer") && !profGender.Contains("Mashkull"))
            {
                return false;
            }

            return true;
        }
    }
}
