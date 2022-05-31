using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap heap = new Heap(13);
            heap.Insertar(1);
            heap.Insertar(2);
            heap.Insertar(13);
            heap.Insertar(4);
            heap.Insertar(5);
            heap.Insertar(6);
            heap.Insertar(7);
            heap.Transversa();
            Console.WriteLine($"minimo : {heap.BorrarMin()}");
            heap.Transversa();

            Console.WriteLine($"minimo : {heap.BorrarMin()}");
            heap.Transversa();
            Console.WriteLine($"minimo : {heap.BorrarMin()}");
            heap.Transversa();
            Console.WriteLine($"minimo : {heap.BorrarMin()}");
            heap.Transversa();
            Console.WriteLine($"minimo : {heap.BorrarMin()}");
            heap.Transversa();
            Console.WriteLine($"minimo : {heap.BorrarMin()}");
            heap.Transversa();

            Console.ReadLine();
        }
    }
}
