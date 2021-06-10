using System;
using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{

    class Program
    {

        static void Main(string[] args)
        {



            //Question1
            Console.WriteLine("Question 1 ");
            DisplayName("My name");
            Console.WriteLine("");

            //Question 2
            Console.WriteLine("Question 2 ");
            decimal firstNumber = 5;
            decimal secondNumber = 2;
            Console.WriteLine("The numbers are: " + firstNumber + " and " + secondNumber + ".");
            decimal sum = Sum(firstNumber, secondNumber);
            DisplayStringWithObject("The sum of the numbers are: ", sum);
            decimal dividing = Divide(firstNumber, secondNumber);
            DisplayStringWithObject("The dividing of the numbers are: ", dividing);
            Console.WriteLine("");

            //Question 3
            Console.WriteLine("Question 3 ");
            int operation1 = -1 + (5 * 6);
            Console.WriteLine("The result of first operation is : " + operation1);
            int operation2 = 38 + (5 % 7);
            Console.WriteLine("The result of second operation is : " + operation2);
            double operation3 = 14 - (double)((double)(3 * 6) / 7);
            Console.WriteLine("The result of third operation is : " + operation3);
            double operation4 = 2 + (((double)13 / 6) * 6) + (double)Math.Sqrt(7);
            Console.WriteLine("The result of  forth operation is : " + operation4);
            double operation5 = (Math.Pow(6, 4) + Math.Pow(5, 7)) / (9 % 4);
            Console.WriteLine("The result of last operation is : " + operation5);
            Console.WriteLine("");

            //Question 4
            Console.WriteLine("Question 4 ");
            Console.WriteLine("Give the first Number ");
            string readLine = Console.ReadLine();
            firstNumber = Convert.ToDecimal(readLine);
            Console.WriteLine("Give the second Number ");
            readLine = Console.ReadLine();
            secondNumber = Convert.ToDecimal(readLine);
            Console.WriteLine("Give the third Number ");
            readLine = Console.ReadLine();
            decimal thirdNumber = Convert.ToDecimal(readLine);

            decimal result = MulThreeNumbers(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine("The result of multiplication is : " + result);
            Console.WriteLine("");

            //Question 5
            Console.WriteLine("Question 5 ");
            firstNumber = 1;
            secondNumber = 2;
            thirdNumber = 3;
            decimal forthNumber = 4;
            decimal fifthNumber = 5;
            result = Average(firstNumber, secondNumber, thirdNumber, forthNumber, fifthNumber);
            Console.WriteLine("The average is : " + result);
            Console.WriteLine("");

            //Question 6
            Console.WriteLine("Question 6 ");
            int age = 20;
            string gender = "female";
            Question6(age, gender);
            Console.WriteLine("");

            //Question 7
            Console.WriteLine("Question 7 ");
            int seconds = 360;
            Question7(seconds);
            Console.WriteLine("");

            //Question 8
            Console.WriteLine("Question 8 ");
            seconds = 360;
            Class1 classQuestion = new Class1();
            classQuestion.Question7Library(seconds);
            Console.WriteLine("");


            //Question 9
            Console.WriteLine("Question 9 ");
            int celcius = 30;
            Question9(celcius);
            Console.WriteLine("");


            //Question 10
            Console.WriteLine("Question 10 ");
            string str = "age";
            Question10(str);
            Console.WriteLine("");



            Console.ReadLine();
        }
        static void DisplayName(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }
        static void DisplayStringWithObject(string str, object obj)
        {
            Console.WriteLine(str + obj + ".");
        }
        static decimal Sum(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;
        }
        static decimal MulThreeNumbers(decimal firstNumber, decimal secondNumber, decimal thirdNumber)
        {
            return firstNumber * secondNumber * thirdNumber;
        }
        static decimal Average(decimal firstNumber, decimal secondNumber, decimal thirdNumber, decimal forthNumber, decimal fifthNumber)
        {
            return (firstNumber + secondNumber + thirdNumber + forthNumber + fifthNumber) / 5;
        }
        static void Question6(int age, string gender)
        {
            Console.WriteLine("You are " + gender + " and look younder than " + age);
        }

        static void Question7(int seconds)
        {
            double minutes = seconds / 60;
            double hours = minutes / 60;
            double days = hours / 24;
            double years = days / 365;

            Console.WriteLine(seconds + " seconds is " + minutes + " minutes or " + hours + " hours or " + days + " days or " + years + " years.");

        }
        static void Question9(int celcius)
        {
            double kelvin = celcius + 273.15;
            Console.WriteLine("The " + celcius + " celcius is " + kelvin + " kelvin.");
        }
        static void Question10(string str)
        {
            Console.WriteLine(" The old string is : " + str);
            string newString = str.Trim('a');
            Console.WriteLine(" The new string is : " + newString);
        }

    }
}
