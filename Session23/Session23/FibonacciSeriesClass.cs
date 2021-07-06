using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session23 {
    public class FibonacciSeriesClass :IFibonacciCalculator{
        public long FibonacciSeries(long n) {
            if (n < 0) {
                throw new ArgumentException("number must be not  negative");
            }
            if (n == 0) {
                return 0;
            }
            else if (n == 1) {
                return 1;
            }else if (n>1 && n < 90) {
                return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
            }
            else {
                throw new ArgumentException("Fibonacci result number too big");

            }

        }
    }
}
