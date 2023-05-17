using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Project.BO
{
    public class Course 
    {
        public int Course_Id { get; set; }
        public string Course_Title { get; set; }
        public string Course_Description { get; set; }
        public int Course_Credits { get; set; }
        public int Department_Id { get; set; }
        public Department Department { get; set; }

    }
}
