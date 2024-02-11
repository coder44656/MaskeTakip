using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimGelistirmeKampiC_.Entities;

namespace YazilimGelistirmeKampiC_.Business
{
    public class CourseManager
    {
        Course[] courses = new Course[3];
        public CourseManager() // constructor (yapıcı blok) 
        {
            Course course1 = new Course();

            course1.Id = 1;
            course1.Name = "C# ";
            course1.Description = ".NET 8 vs.";
            course1.Price = 40;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "JAVA";
            course2.Description = "java 17 ";
            course2.Price = 100;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "python";
            course3.Description = "python 3.0 ";
            course3.Price = 105;

            courses[0] = course1;
            courses[1] = course2;
            courses[2] = course3;


            Console.WriteLine("Başladı ... ");
        }
        public Course[] GetAll()
        {
            return courses;
        }
    }
}
