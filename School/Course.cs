using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        public List<Student> Students { get; set; }
        public string  Name { get; set; }

        public void Add(Student s)
        {
            Students.Add(s);
        }
    }
}
