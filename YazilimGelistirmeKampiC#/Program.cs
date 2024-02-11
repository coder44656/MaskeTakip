using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimGelistirmeKampiC_.Business;
using YazilimGelistirmeKampiC_.Entities;

namespace YazilimGelistirmeKampiC_
{
        class Program
    {
        static void Main(string[] args)
        {
            string message1 = "Krediler ";
            int term = 12;
            double amount = 10000.5 ;
            Console.WriteLine(message1);


            bool isAuthenticated = false;

           if (isAuthenticated  == true)
            {
                Console.WriteLine("buton --> hoşgeldin alperen ");
            }
            Console.WriteLine("kod bitti ");

            string[] loans = { "kredi1 ", "kredi2", "kredi3", "kredi4" ,"kredi5 " , "kredi6"  };

               //start       //condition    //increment 
            for (int i = 0; i < loans.Length; i++)
            {
                Console.WriteLine(loans[i]);
            }

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


            Course[] courses = { course1 , course2 , course3 };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i] .Name + " / " + courses[i] .Price + " / " + courses[i].Id);
            }


            CourseManager coursemanager =   new CourseManager();
            Course[] courses2 =  coursemanager.GetAll();

            for (int i = 0; i < courses2.Length; i++)
            {
                Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price + " / " + courses2[i].Id);
            }


        }
    }
}
