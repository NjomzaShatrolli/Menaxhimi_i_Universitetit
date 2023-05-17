using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TI_Project.DAL.Helpers;
using TI_Project.DAL;
using System.Data.SqlClient;
using System.Data;

namespace TIProject.BLL
{
    public static class ClassBLL
    {
        public static object LoadData()
        {
            var classes = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.GetClass, null).ToClassList();
            return classes;
        }

        public static void VerifyData(string Semester, int Year, DateTime StartT, DateTime EndT, string RoomId, int CourseId, int ProfId)
        {
            if (Semester == null || Year == 0 || StartT == null || EndT == null || RoomId == null || CourseId == 0 || ProfId == 0)
            {
                MessageBox.Show("Please Fill All Enteries!");
                return;
            }

            var parameters = new[]
            {
                new SqlParameter("@room_number", SqlDbType.VarChar) { Value = RoomId },
                new SqlParameter("@start_time", SqlDbType.Date) { Value = StartT },
                new SqlParameter("@end_time", SqlDbType.Date) { Value = EndT }
            };

            var room = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.CheckIfRoomIsFree, parameters).ToClassList();


            if(room.Count > 0)
            {
                MessageBox.Show("Room is not free!");
                return;
            }

            DAClass.SaveData(Semester, Year, StartT, EndT, RoomId, CourseId, ProfId);
        }

        public static void VerifyToUpdateData(int id, string Semester, int Year, DateTime StartT, DateTime EndT, string RoomId, int CourseId, int ProfId)
        {
            if (id == 0 || Semester == null || Year == 0 || StartT == null || EndT == null || RoomId == null || CourseId == 0 || ProfId == 0)
            {
                MessageBox.Show("Please Select Record To Update!");
                return;
            }

            DAClass.UpdateData(id, Semester, Year, StartT, EndT, RoomId, CourseId, ProfId);

        }

        public static void VerifyToDelete(int id)
        {
            if (id != 0)
            {
                DAClass.DeleteData(id);
            }
            else
            {
                MessageBox.Show("Please Select Record To Delete!");
            }
        }
    }
}
