using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Project.DAL.Helpers
{
    public static class DataBaseHelper
    {
        public static SqlConnection GetSQLConnection()
        {
            return new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings.Get("sqlConnection"));
        }

        public static DataTable ExecuteStoredProcedure(string storedProcedureName, SqlParameter[] parameters = null)
        {
            using (var connection = GetSQLConnection())
            {
                using (var command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    var adapter = new SqlDataAdapter(command);
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
    }
}
