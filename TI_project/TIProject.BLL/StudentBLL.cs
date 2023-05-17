using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI_Project.BO;
using TI_Project.DAL;
using TI_Project.DAL.Helpers;

namespace TIProject.BLL
{
    public static class StudentBLL
    {
        public static object LoadData()
        {
            var students = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.GetStudents, null).ToStudentList();
            return students;
        }

        public static void VerifyData(string StudName, string StudEmail, string StudPhone, string StudAdd, string StudGender, DateTime StudBirthday, int DepId)
        {
            if (StudName == null || StudEmail == null || StudPhone == null || StudAdd == null || StudGender == null || StudBirthday == null || StudBirthday > DateTime.Today || DepId == 0)
            {
                MessageBox.Show("Please check your enteries and date!");
                return;
            }

            if (!VerifyEmail(StudEmail))
            {
                MessageBox.Show("Please check your Email!");
                return;
            }

            if(!VerifyGender(StudGender))
            {
                MessageBox.Show("The input on Gender was incorrect!");
                return;
            }

            DAStudents.SaveData(StudName, StudEmail, StudPhone, StudAdd, StudGender, StudBirthday, DepId);
        }

        public static void VerifyToUpdateData(int id, string StudName, string StudEmail, string StudPhone, string StudAdd, string StudGender, DateTime StudBirthday, int DepId)
        {
            if (id == 0 || StudName == null || StudEmail == null || StudPhone == null || StudAdd == null || StudGender == null || StudBirthday == null || StudBirthday > DateTime.Today || DepId == 0)
            {
                MessageBox.Show("Please Select Record to Update");
                return;
            }

            if (!VerifyEmail(StudEmail))
            {
                MessageBox.Show("Please check your Email!");
                return;
            }

            if (!VerifyGender(StudGender))
            {
                MessageBox.Show("The input on Gender was incorrect!");
                return;
            }

            DAStudents.UpdateData(id, StudName, StudEmail, StudPhone, StudAdd, StudGender, StudBirthday, DepId);

        }

        public static void VerifyToDelete(int id)
        {
            if (id != 0)
            {
                DAStudents.DeleteData(id);
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        public static bool VerifyEmail(string Email) 
        {
           
            if (!Email.Contains("@gmail.com") && !Email.Contains("@hotmail.com"))
            {
                return false;
            }

            return true;
        }

        public static bool VerifyGender(string Gender)
        {

            if (!Gender.Contains("Female") && !Gender.Contains("Male") && !Gender.Contains("F") && !Gender.Contains("M")
                && !Gender.Contains("Femer") && !Gender.Contains("Mashkull"))
            {
                return false;
            }

            return true;
        }
    }
}
