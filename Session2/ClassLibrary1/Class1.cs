using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public void Question7Library(int seconds)
        {
            double minutes = seconds / 60;
            double hours = minutes / 60;
            double days = hours / 24;
            double years = days / 365;

            Console.WriteLine(seconds + " seconds is " + minutes + " minutes or " + hours + " hours or " + days + " days or " + years + " years.");

        }
    }
}
