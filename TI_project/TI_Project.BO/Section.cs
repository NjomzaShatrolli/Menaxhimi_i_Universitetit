using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Project.BO
{
    public class Section : Base
    {
        public string Semester { get; set; }
        
        public int Year { get; set; }
        
        public DateTime Start_Time { get; set; }
        
        public DateTime End_Time { get; set;}
        
        public string Room_Number { get; set; }
        
        public Course Course_Id { get; set; }
        
        public Faculty Faculty_Id { get; set; }
    }
}
