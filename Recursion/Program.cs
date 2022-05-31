using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,1,2,3,5,8,13
            //0,1,2,3,4,5,6
          Console.WriteLine(RecursionClass.Fibo(4));

            Console.ReadLine();
        }
    }

    public static class RecursionClass
    {


        public static int Factorial(int n)
        {
            int r = 0;

            // caso recursivo
            if (n > 1)
                r = n * Factorial(n - 1);

            // caso base
            if (n == 1)
                r = 1;
            return r;

        }
        // Factorial(4)
        // Factorial(4) = 4 * Factorial(3)
        // Factorial(3) = 3 * Factorial(2)
        // Factorial(2) = 2 * Factorial(1)
        //Casos base Factorial(1) = 1
        //Retorno de la recursión
        // Factorial(1) = 1
        // Factorial(2) = 2 * Factorial(1) = 1 => 2*1 = 2
        // Factorial(3) = 3 * Factorial(2) = 2 => 3*2 = 6
        // Factorial(4) = 4 * Factorial(3) = 6 => 4*6 = 24

        public static int Fibo(int n)
        {
            int r = 0;
            // caso recursivo
            if (n > 1)
                r = Fibo(n - 1) + Fibo(n - 2);

            // caso base
            if (n<= 1)
                r = 1;
            return r;
        }
        // corrida Fibo(5)
        // Fibo(5) = Fibo(4) + Fibo(3)
        // Fibo(4) = Fibo(3) + Fibo(2)
        // Fibo(3) = Fibo(2) + Fibo(1)
        // Fibo(2) = Fibo(1) + Fibo(0)
        //Casos base Fibo(1) y Fibo(0) = 1
        //Retorno de la recursión
        //Fibo(0) = 1
        // Fibo(1) = 1
        // Fibo(2) = Fibo(1) = 1 + Fibo(0) = 1 => 1+1 = 2
        // Fibo(3) = Fibo(2) = 2 + Fibo(1) = 1 => 2+1 = 3
        // Fibo(4) = Fibo(3) = 3 + Fibo(2) = 2 => 3+2 = 5
        // Fibo(5) = Fibo(4) = 5 + Fibo(3) = 3 => 5+3 = 8

    }
}

