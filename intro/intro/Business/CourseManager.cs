using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Business
{
    public class CourseManager
    {
        Course[] courses = new Course[2];
        public CourseManager()
        {
            Course course1 = new();
            course1.Name = "C#";
            course1.Description = "Bu bir c# kursu";
            course1.Id = 1;
            course1.Price = 50;

            Course course2 = new();
            course2.Name = "JAVA";
            course2.Description = "Bu bir java kursu";
            course2.Id = 2;
            course2.Price = 30;

            courses[0] = course1;
            courses[1] = course2;

        }
        public Course[] GetAll()
        {
            return courses;
        }
    }
}
    

   

