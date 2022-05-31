using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPila
{
    class Program
    {
        static void Main(string[] args)
        {
            CStack cStack = new CStack();
            bool isMoreCosedSignal = false;

            string expresion = string.Empty;
            Console.WriteLine("Expresion : ");
            expresion = Console.ReadLine();

            foreach (char c in expresion)
            {
                if (c == '(' || c == '{' || c == '[')
                    cStack.Push(c);

                if (c == ')' || c == '}' || c == ']')
                {
                    if (cStack.IsEmpty()) {
                        isMoreCosedSignal = true;
                        Console.WriteLine("Exceso de simbolos de cierre");
                        break;
                    }
                    char popValue = cStack.Pop();
                    if (!Compare(c, popValue))
                    {
                        Console.WriteLine("Simbolos {0} de cierre equivocado", c);
                        break;
                    }
                }
            }

            if (cStack.IsEmpty() && !isMoreCosedSignal)
                Console.WriteLine("Hay balance de Simbolos");
            else
                Console.WriteLine("No hay balance de Simbolos");

            Console.ReadLine();



            //cStack.Push('5');
            //cStack.Push('3');
            //cStack.Push('7');
            //cStack.Push('9');
            //cStack.Transversa();
            //Console.WriteLine("Pop : [{0}]",cStack.Pop());
            //cStack.Transversa();
            //Console.WriteLine("Peek : [{0}]", cStack.Peek());
            //cStack.Transversa();
        }

        static bool Compare(char expresionValue, char popValue) {

            if (popValue == '(' && expresionValue != ')')
                return false;
            if (popValue == '{' && expresionValue != '}')
                return false;
            if (popValue == '[' && expresionValue != ']')
                return false;
            return true;

        }
    }
}
