using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Project.BO
{
    public class Student : Base
    {
        public string Student_Name { get; set; }

        public string Student_Email { get; set; }

        public string Student_Number { get; set; }

        public string Student_Address { get; set; }

        public string Student_Gender { get; set; }

        public DateTime Student_Birthday { get; set; }

    }
}
