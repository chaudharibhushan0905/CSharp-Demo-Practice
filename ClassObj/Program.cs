using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{

    /* class Car
     {
         string color = "black";

         static void Main(string[] args)
         {
             Car c = new Car();
             Console.WriteLine(c.color);
             Console.ReadLine();
         }
     }*/
    public class Student
    {
        int id;
        string name;

        public static void Main(string[] args)
        {
            Student s = new Student();
            s.id = 47;
            s.name = "Bhushan";
            Console.WriteLine(s.id);
            Console.WriteLine(s.name);
            Console.ReadLine();
        }
    }
}
