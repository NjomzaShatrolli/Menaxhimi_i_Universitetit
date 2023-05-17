using System;

namespace TI_Project.BO
{
    public class Class
    {
        public int Class_Id { get; set; }
        public string Semester { get; set; }

        public int Year { get; set; }

        public DateTime Start_Time { get; set; }

        public DateTime End_Time { get; set; }

        public string Room_Number { get; set; }

        public int Course_Id { get; set; }

        public Course Course { get; set; }

        public int Prof_Id { get; set; }

        public Faculty Faculty { get; set; }
    }
}
