using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba3_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studIvanov = new Student();
            studIvanov.NumberGroup = 10321;
            studIvanov.StudentNumberInTheGroup = 1;
            studIvanov.LastName = "Ivanov";
            studIvanov.firtsName = "Oleg";
            studIvanov.middleName = "Petrovich";
            studIvanov.ArrayScore = new int[] { 10, 7, 6, 9, 8 };
            Console.WriteLine(studIvanov);
            Console.WriteLine($"Average Score: {studIvanov.AverageScore()}");
            Console.WriteLine("--------------------------------------------------------------");
            Student studPetrov = new Student(10322, 2, "Petrov", "Aleksey", "Sidorovich");
            try
            {
                studPetrov.ArrayScore = new int[] { 7, 9, 5, 8, 4 };
                Console.WriteLine(studPetrov);
                Console.WriteLine($"Average Score: {studPetrov.AverageScore()}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"{studIvanov.LastName} more successful, than {studPetrov.LastName} on the {studIvanov.SuccessfulStudent(studPetrov)} points");
            Console.WriteLine($"{studIvanov.LastName} more successful, than {studPetrov.LastName} \n { studIvanov.SuccessfulStudentBool(studPetrov)} ");
            Console.WriteLine("-----------------------------------------------------------");
            Student studSidorov = new Student(10323, 3, "Sidorov", "Andrey", "Viktorovich", new int[] { 5, 6, 5, 3, 7 });
            Console.WriteLine(studSidorov);
            Console.WriteLine($"Average Score: {studSidorov.AverageScore()}");
            /*Student std1 = new Student();
            Console.WriteLine(std1);*/
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Most successful student of all \n\n" + Student.MostSuccessfulOfAll(studIvanov,studPetrov,studSidorov));
            Console.WriteLine("------------------------------------------------------------");
            studIvanov.ArrayScore = new int[] { 10, 7, 6, 3, 8 };
            studIvanov.CorrectNumberGroup();
            Console.WriteLine(studIvanov);
        }
    }
}
