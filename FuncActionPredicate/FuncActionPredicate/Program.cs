using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mathClass = new MathClass();
            //Solution 1
            //Func<int, int, int> calc = mathClass.Sum;
            //int result = calc(4, 5);

            //Solucion 2
            // int result = mathClass.ComplexSum(5, 4, mathClass.Sum);

            //Solucion 3
            Func<int, int, int> calc = delegate (int a, int b) { return a + b; };
            int result = calc(4, 8);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
    public class MathClass {

        public int Sum(int a, int b) => a + b;

        public int Rest(int a, int b) => a - b;

        public int ComplexSum(int a, int b,Func<int, int, int> calc) {
            return calc(a,b);
        }
    }
}
