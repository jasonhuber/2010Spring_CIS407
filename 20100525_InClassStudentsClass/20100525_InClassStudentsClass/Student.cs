using System;
using System.Collections.Generic;
using System.Text;

namespace _20100525_InClassStudentsClass
{
    public class Student
    {
        private string _dnumber;

        public string dnumber  {
            get { return _dnumber; }
            set {
                    if (value.ToUpper().Substring(0, 1) != "D")
                    {
                        throw new Exception("You need to enter a D number (those start with D)");
                    }
                    else
                    { _dnumber = value; }
                }
        }

    }

    public class Course
    {
        //http://www.codeproject.com/KB/cs/csharp_property_array.aspx
        private Student[] _students = new Student[10];

        public Course()
        {
            _students[0] = new Student();
            _students[1] = new Student();
            _students[2] = new Student();
            _students[3] = new Student();
            _students[4] = new Student();
            _students[5] = new Student();
            _students[6] = new Student();
            _students[7] = new Student();
            _students[8] = new Student();
            _students[9] = new Student();

        }
         
        public Student[] students{
            get { return _students; } 
            set{_students = value;}
            }
    }
}
