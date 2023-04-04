using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Project.BO
{
    public class Enrollment : Base
    {
        public DateTime Enrollment_Date { get; set; }
      
        public string Grade { get; set; }
        
        public Section Section_Id { get; set; }
        
        public Student Student_Id { get; set; }
    }
}
