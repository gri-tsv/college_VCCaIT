using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClass;
using MyTest;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Myclass class1 = new Myclass();

            int i1 = class1.Rsch(1000, 220, 300, 9, 1, 6);
            int i2 = class1.Rsch(1000, 321, 432, 4, 3, 2);

            int i = i1+ i2;
            Console.WriteLine(i1);
            Console.WriteLine(i2);
            Console.WriteLine(i);

            UnitTest1 class2 = new UnitTest1();
            //class2.HandOver();
            //class2.Equls();
            //class2.DevindedByZeero();


            class2.TestEuls4();

        }
    }
}