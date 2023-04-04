using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Project.BO
{
    public class Course : Base
    {
        public string Course_Title { get; set; }
        public string Course_Description { get; set; }
        public int Course_Credits { get; set; }
        public Departament Department_Id { get; set; }

    }
}
