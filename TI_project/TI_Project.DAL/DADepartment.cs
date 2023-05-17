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
    public static class DADepartment
    {
        public static List<Department> ToDepartmentList(this DataTable table)
        {
            var departments = new List<Department>();

            foreach (DataRow row in table.Rows)
            {
                var department = new Department
                {
                    Department_Id = Convert.ToInt32(row["department_id"]),
                    Department_Name = Convert.ToString(row["department_name"]),
                    Department_Description = Convert.ToString(row["department_description"])
                };

                departments.Add(department);
            }

            return departments;
        }

        public static void SaveData(string DepName, string DepDesc)
        {
            var parameters = new[]
            {
                    new SqlParameter("@department_name", SqlDbType.VarChar) { Value = DepName },
                    new SqlParameter("@department_description", SqlDbType.VarChar) { Value = DepDesc }
            };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.CreateDepartment, parameters);

            MessageBox.Show("Department Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }
        public static void UpdateData(int id, string DepName, string DepDesc)
        {
            var parameters = new[]
            {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = id },
                    new SqlParameter("@department_name", SqlDbType.VarChar) { Value = DepName },
                    new SqlParameter("@department_description", SqlDbType.VarChar) { Value = DepDesc }
            };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.UpdateDepartment, parameters);

            MessageBox.Show("Record Updated Successfully!");
        }

        public static void DeleteData(int id) 
        {
            var parameters = new[]
            {
                    new SqlParameter("@ID", SqlDbType.Int) { Value = id }
            };

            var result = DataBaseHelper.ExecuteStoredProcedure(StoredProcedures.DeleteDepartment, parameters);

            MessageBox.Show("Record Deleted Successfully!");
        }

    }
    
}
