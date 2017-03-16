using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        public int CourseID { get; private set; } = 0;
        public string Name { get; private set; } = "";
        public DateTime StartsAt { get; private set; } = DateTime.Today;
        public List<Student> Students { get; private set; } = new List<Student>();

        public Course(int courseID, string name)
        {
            CourseID = courseID;
            Name = name;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
