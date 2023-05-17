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
    public static class CourseBLL
    {
        public static object LoadData()
        {
            var courses = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.GetCourse, null).ToCourseList();
            return courses;
        }

        public static void VerifyData(string CourseTitle, string CourseDesc, int CourseCreds, int DepId)
        {
            if (CourseTitle == null || CourseDesc == null || CourseCreds == 0 || DepId == 0)
            {
                MessageBox.Show("Please Fill All Enteries!");
                return;
            }

            DACourse.SaveData(CourseTitle, CourseDesc, CourseCreds, DepId);
        }

        public static void VerifyToUpdate(int id, string CourseTitle, string CourseDesc, int CourseCreds, int DepId)
        {
            if(id == 0 || CourseTitle == null || CourseDesc == null || CourseCreds == 0 || DepId == 0)
            {
                MessageBox.Show("Please Select A Record To Update!");
                return;
            }

            DACourse.UpdateData(id, CourseTitle, CourseDesc, CourseCreds, DepId);
        }

        public static void VerifyToDelete(int id)
        {
            if (id != 0)
            {
                DACourse.DeleteData(id);
            }
            else
            {
                MessageBox.Show("Please Select A Record To Delete!");
            }
        }

    }
}
