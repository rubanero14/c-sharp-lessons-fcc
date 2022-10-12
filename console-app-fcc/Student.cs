using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_fcc
{
    class Student
    {
        public string name;
        public string major;
        public decimal gpa;

        public Student(string Name, string Major, decimal Gpa)
        {
            name = Name;
            major = Major;
            gpa = Gpa;
        }

        // Custom Object Method to determine whether a student has Honors if student's GPA is 3.5 and above
        public bool hasHonors()
        {
            if(gpa >= 3.50m)
            {
                return true;
            }
            return false;
        }
    }
}
