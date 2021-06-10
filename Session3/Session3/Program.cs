using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 class1 = new Class1();
            //Question 1
            Console.WriteLine("Question 1\n");
            Console.WriteLine(class1.Question1());
            Console.WriteLine("");

            //Question 2
            Console.WriteLine("Question 2\n");
            Console.WriteLine(class1.Question2());
            Console.WriteLine("");

            //Question 3
            Console.WriteLine("Question 3\n");
            class1.Question3();
            Console.WriteLine("");

            //Question 4
            Console.WriteLine("Question 4\n");
            class1.Question4();
            Console.WriteLine("");

            //Question 5
            Console.WriteLine("Question 5\n");
            class1.Question5();
            Console.WriteLine("");

            //Question 6
            Console.WriteLine("Question 6\n");
            class1.Question6();
            Console.WriteLine("");

            Console.WriteLine("The end");
            Console.ReadLine();
        }
    }
}
