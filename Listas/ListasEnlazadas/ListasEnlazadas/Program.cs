using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList listita = new LinkedList();
            listita.InsertNode(3);
            listita.InsertNode(5);
            listita.InsertNode(7);
            listita.InsertNode(9);
            listita.InsertNode(11);
            listita.InsertNode(15);
            bool isempty = listita.IsEmpty();
            listita.Trasverse();
            //listita.Clear();
            //listita.IsEmpty();
            //bool isempty2 = listita.IsEmpty();
            //listita.Trasverse();
            Node exist = listita.Search(77);
            int index = listita.SearchIndex(5);

           Node temp =  listita.GetBeforeNode(3);
          //  listita.Trasverse();

            listita.InsertStart(1);
            listita.Trasverse();

           Node nodeByIndex = listita.GetByIndex(3);
            listita[0] = 4;

            int valueNodo = listita[1].Value;
            Console.ReadLine();
        }
        



    }
}
