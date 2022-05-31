using System;
using System.Collections.Generic;
using System.Text;

namespace GrafosProject
{
    /// <summary>
    /// Ordenamiento topologico
    /// </summary>
   public class Grafo
    {
        int[,] mAdyacencia;
        int[] indegree;
        int nodos;

        public Grafo(int pNodo) {
            nodos = pNodo;
            //Instanciamos la matriz de adyacencia
            mAdyacencia = new int[nodos, nodos];

            //Instanciamos arreglo Indegree
            indegree = new int[nodos];
        }

        /// <summary>
        /// adiciona las aristas desde el nodo inicio al nodo final, el 1 inidica que alli hay una arista
        /// Una arista = relacion entre un nodo y otro
        /// </summary>
        /// <param name="pNodoInicio"></param>
        /// <param name="pNodoFinal"></param>
        public void AdicionarArista(int pNodoInicio, int pNodoFinal) {
            mAdyacencia[pNodoInicio, pNodoFinal] = 1;
        }


        /// <summary>
        /// Muestra la matriz de adyacencia
        /// </summary>
        public void MuestraAdyacencia() {
            int m = 0;
            int n = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (n = 0; n < nodos; n++)
                Console.Write("\t{0}", n);

            Console.WriteLine();

            for (n = 0; n < nodos; n++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(n);
                for (m = 0; m < nodos; m++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\t{0}", mAdyacencia[n, m]);

                }
                Console.WriteLine();
            }
        }

        public void CalcularIndegree() {
            int n = 0;
            int m = 0;
            for (n= 0; n < nodos; n++)
            {
                for (m= 0; m < nodos; m++)
                {
                    if (mAdyacencia[m, n] == 1)
                        indegree[n]++;
                }

            }
        }

        public void MostrarIndegree() {
            int n = 0;
            Console.ForegroundColor = ConsoleColor.White;
            for (n = 0; n < nodos; n++)
            {
                Console.WriteLine($"Nodo : {n}, {indegree[n]}");
            }
        
        }

        public int EncuentraIndegreeDe0() {

            bool encontrado = false;
            int n = 0;
            for (n = 0; n < nodos; n++)
            {
                if (indegree[n] == 0) {
                    encontrado = true;
                    break;
                }
            }
            if (encontrado)
                return n;
            else
                return -1;
        }

        public void DecrementarIndegree(int pNodo) {
            indegree[pNodo] = -1;
            int n = 0;
            for (n = 0; n < nodos; n++)
            {
                if (mAdyacencia[pNodo, n] == 1)
                    indegree[n]--;
            }
        }

    }
}
