using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3
{
    class Class1
    {

        public string Question1()
        {
            string setence = "lorem ipsum dolor sit amet consectetur adipiscing elit";
            string[] words = setence.Split(' ');
            int wordMaxLength = 0;
            string longestWord = "";
            string longestWordUppercase = "";
            foreach (string word in words)
            {

                if (word.Length > wordMaxLength)
                {
                    wordMaxLength = word.Length;
                    longestWord = word;
                }
            }
            longestWordUppercase = longestWord.ToUpper();
            return longestWordUppercase;

        }
        public string Question2()
        {

            string word = "hello";
            char[] charsOfWord = word.ToCharArray();
            string reversedString = "";

            Array.Reverse(charsOfWord);
            reversedString = string.Join("", charsOfWord);

            return reversedString;
        }
        public void Question3()
        {
            int n;
            do
            {
                Console.WriteLine("Give me a number: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            Console.WriteLine("Press 1 to  compute the sum or 2 to compute the product: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Sum(n);
                    break;
                case 2:
                    Product(n);
                    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    break;
            }

        }
        public void Question4()
        {
            int n;
            do
            {
                Console.WriteLine("Give me a number  to canculate the primes: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            int countDivided;
            for (int i = 2; i <= n; i++)
            {
                countDivided = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        countDivided++;
                    }
                }
                if (countDivided == 2)
                {//prime
                    Console.WriteLine("prime: " + i);
                }
            }
        }
        public void Question5()
        {
            int[] array1 = { 2, 4, 9, 12 };
            int[] array2 = { 1, 3, 7, 10 };
            int[] results = new int[16];
            int index = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    results[index] = array1[i] * array2[j];
                    index++;
                }

            }
            Console.WriteLine(string.Join(", ", results));

        }
        public void Question6()
        {
            int[] array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            Array.Sort(array);

            Console.WriteLine(string.Join(", ", array));

        }
        public void Sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("The sum of {0} is: {1}", n, sum);
        }
        public void Product(int n)
        {
            int product = 1;
            for (int i = 2; i <= n; i++)
            {
                product = product * i;
            }
            Console.WriteLine("The product of {0} is: {1}", n, product);
        }



    }
}
