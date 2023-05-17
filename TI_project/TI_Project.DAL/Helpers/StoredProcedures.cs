using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Project.DAL.Helpers
{
    public class StoredProcedures
    {
        public const string GetStudents = "GetStudents";
        public const string CreateStudent = "CreateStudent";
        public const string UpdateStudent = "Updatestudent";
        public const string DeleteStudent = "DeleteStudent";


        public const string GetDepartment = "GetDepartment";
        public const string CreateDepartment = "CreateDepartment";
        public const string UpdateDepartment = "UpdateDepartment";
        public const string DeleteDepartment = "DeleteDepartment";

        public const string GetFaculty = "GetFaculty";
        public const string CreateFaculty = "CreateFaculty";
        public const string UpdateFaculty = "UpdateFaculty";
        public const string DeleteFaculty = "DeleteFaculty";

        public const string GetCourse = "GetCourse";
        public const string CreateCourse = "CreateCourse";
        public const string UpdateCourse = "UpdateCourse";
        public const string DeleteCourse = "DeleteCourse";

        public const string GetClass = "GetClass";
        public const string CreateClass = "CreateClass";
        public const string UpdateClass = "UpdateClass";
        public const string DeleteClass = "DeleteClass";
        public const string DeleteClassByProfId = "DeleteClassByProfId";
        public const string CheckIfRoomIsFree = "CheckIfRoomIsFree";


    }
}
