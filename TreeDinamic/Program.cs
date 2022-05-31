using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            CArbol arbol = new CArbol();
            Cnodo raiz = arbol.Insertar("A", null);
            arbol.Insertar("B", raiz);
            arbol.Insertar("C", raiz);

            // En memoria N es un punto de Raiz
            Cnodo N = arbol.Insertar("D", raiz);
            // Por eso este nodo tambien se añade a Raiz
            arbol.Insertar("H", N);

            N = arbol.Insertar("E", raiz);
            arbol.Insertar("I", N);

            N= arbol.Insertar("J", N);
            arbol.Insertar("P", N);
            arbol.Insertar("Q", N);

          //  arbol.TransversaPre(raiz);

            N = arbol.Insertar("F", raiz);
            arbol.Insertar("K", N);
            arbol.Insertar("L", N);
            arbol.Insertar("M", N);

            N = arbol.Insertar("G", raiz);
            arbol.Insertar("N", N);

            arbol.TransversaPre(raiz);
            Console.WriteLine("------------------");
            arbol.TransversaPost(raiz);
            Console.WriteLine("------------------");

            Cnodo cnodoBuscar = arbol.Buscar("N", raiz);
            if (cnodoBuscar != null)
                Console.WriteLine("Nodo {0} encontrado", cnodoBuscar.Dato);
            else
                Console.WriteLine("Nodo No encontrado");


            // Proceso de Inserción
            string donde = "";
            string que = "";
            Console.WriteLine("En dónde deseas insertar?");
            donde = Console.ReadLine();
            Console.WriteLine("Qué deseas insertar?");
            que = Console.ReadLine();
            Cnodo encontrado = arbol.Buscar(donde, raiz);
            arbol.Insertar(que, encontrado);
            arbol.TransversaPre(raiz);

            Console.ReadLine();
        }
    }
}
