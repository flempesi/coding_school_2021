using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4
{
    class ClassQuestion1
    {

        public void DecimalToBinary()
        {
            int number = 2;
            string binary = Convert.ToString(number, 2);
            Console.WriteLine(string.Format("The binary of the number {0} is : {1}", number, binary));
        }
    }
}
