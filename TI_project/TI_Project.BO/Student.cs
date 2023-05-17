using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Project.BO
{
    public class Student
    {
        public int Stud_Id { get; set; }
        public string Student_Name { get; set; }

        public string Student_Email { get; set; }

        public string Student_Phone { get; set; }

        public string Student_Address { get; set; }

        public string Student_Gender { get; set; }

        public DateTime Student_Birthday { get; set; }

        public int Department_Id { get; set; }  

        public Department Departament{ get; set; }

    }
}
