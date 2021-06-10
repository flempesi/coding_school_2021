using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            ClassQuestion1 question1 = new ClassQuestion1();
            Console.WriteLine("Question1\n");
            question1.DecimalToBinary();


            //Question 2
            ClassQuestion2 question2 = new ClassQuestion2();
            Console.WriteLine("Question2\n");
            Professor professor = new Professor();
            professor.Name = "Myname";
            Console.WriteLine("The name of the professor that i entered is {0}", professor.GetName());



            Console.ReadLine();
        }
    }
}
