using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp3
{
   public static class testClass
    {
        public static string a;
        static testClass() {
            a = "AAA";
        }

        public static int Factorial(int n) {
            int r = 0;

            // caso recursivo
            if (n > 1)
                r = n * Factorial(n - 1);

            // caso base
            if (n == 1)
                r = 1;
            return r;

        }

        public static int Fibo(int n) {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibo(n - 1) + Fibo(n - 2);
            }

        }
    }
}
//4321
//31



// n = 4  
// n = 3
// n = 2
// n = 1
// return r = 1
// r = 2 * 1
// r = 3 * 2 donde  2 => (2*1)
// r = 4 * 6 donde  6 => (3*2) 