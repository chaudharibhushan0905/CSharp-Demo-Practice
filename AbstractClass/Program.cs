using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Test
    {
        public abstract void disp();
    }

    public class Rectangle : Test
    {
        public override void disp()
        {
            Console.WriteLine("Displaying Rectangle");
        }

    }

    public class Circle : Test
    {
        public override void disp()
        {
            Console.WriteLine("Displaying Circle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test s;
            s = new Rectangle();
            s.disp();
            s = new Circle();
            s.disp();
            Console.ReadLine();

        }
    }
}
