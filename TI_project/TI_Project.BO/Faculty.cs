using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Project.BO
{
    public class Faculty 
    {
        public int Prof_Id { get; set; }

        public string Prof_Name { get; set; }
       
        public string Prof_Email { get; set; }

        public string Prof_Phone { get; set; }

        public string Prof_Address { get; set; }

        public string Prof_Gender { get; set; }

        public int Department_Id { get;set; }

        public Department Department { get; set; }
    }
}
