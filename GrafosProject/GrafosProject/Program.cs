using System;

namespace GrafosProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int nodo = 0;
            Grafo miGrafo = new Grafo(7);
            miGrafo.AdicionarArista(0, 1);
            miGrafo.AdicionarArista(0, 2);
            miGrafo.AdicionarArista(0, 3);
            miGrafo.AdicionarArista(1, 3);
            miGrafo.AdicionarArista(1, 4);
            miGrafo.AdicionarArista(2, 5);
            miGrafo.AdicionarArista(3, 2);
            miGrafo.AdicionarArista(3, 5);
            miGrafo.AdicionarArista(3, 6);
            miGrafo.AdicionarArista(4, 3);
            miGrafo.AdicionarArista(4, 6);
            miGrafo.AdicionarArista(6, 5);

            miGrafo.MuestraAdyacencia();
            miGrafo.CalcularIndegree();
            miGrafo.MostrarIndegree();

            Console.ForegroundColor = ConsoleColor.Cyan;
            do
            {
                // Encontramos el nodo con el Degree 0
                nodo = miGrafo.EncuentraIndegreeDe0();
                if(nodo != -1)
                {
                    Console.Write($"{nodo} -->");
                    //decrementamos los Indegree
                    miGrafo.DecrementarIndegree(nodo);
                }

            } while (nodo != -1);
            Console.WriteLine();

        }
    }
}
