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
    public static class DepartmentBLL
    {
        public static object LoadData()
        {
            var departments = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.GetDepartment, null).ToDepartmentList();
            return departments;
        }

        public static void VerifyData(string DepName, string DepDesc)
        {
            if(DepName is null || DepDesc is null)
            {
                MessageBox.Show("Please fill all enteries");
                return; 
            }

            DADepartment.SaveData(DepName, DepDesc);
        }

        public static void VerifyToUpdateData(int id, string DepName, string DepDesc) 
        { 
            if(id != 0 && DepName != null && DepDesc != null)
            {
                DADepartment.UpdateData(id, DepName, DepDesc);
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        
        }

        public static void VerifyToDelete(int id)
        {
            if (id != 0)
            {
                DADepartment.DeleteData(id);
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

    }
}
