using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Project.BO
{
    public class Faculty : Base
    {
        public string Faculty_Name { get; set; }
       
       public string Faculty_Email { get; set; }

        public string Faculty_Phone { get; set; }

        public string Faculty_Address { get; set; }

        public Departament Department_Id { get; set; }
    }
}
