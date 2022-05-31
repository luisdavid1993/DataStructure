using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas
{
  public  class LinkedList
    {
        public Node startNode;
        private Node workNode;

        public LinkedList()
        {
            startNode = new Node();
            startNode.Next = null;
        }

        public void DeleteValues(int numberCounter) {
            workNode = startNode;
            int iterator = 0;;
            while (workNode.Next != null && iterator <= numberCounter)
            {
                workNode = workNode.Next;
                iterator++;
            }
            startNode = workNode;

        }
        /// <summary>
        /// Inserta el valor en la lista enlazada
        /// </summary>
        /// <param name="vale"></param>
        public void InsertNode(int vale) {
            workNode = startNode;
            // se avanza hasta el nodo nulo
            while (workNode.Next != null)
            {
                workNode = workNode.Next;
            }
            // en el nodo temporal se asiga el nuevo valor
            Node tempNode = new Node();
            tempNode.Value = vale;
            // el siguiente se coloca en nulo
            tempNode.Next = null;
            workNode.Next = tempNode;
        }
        /// <summary>
        /// Recorre el nodo
        /// </summary>
        public void Trasverse() {

            //Trabajo al Inicio
            workNode = startNode;
            //Recorremos hasta encontrar el final
            while (workNode.Next != null)
            {
                //Avanzamos trabajo
                workNode = workNode.Next;
                //Obtenemos el dato y lo mostramos
                int d = workNode.Value;
                Console.Write("{0} -> ", d);
            }
            //Bajamos la linea
            Console.WriteLine();
        }
        /// <summary>
        /// Como c# es un lenguaje que administa la memoria, al hacer null el valor el gabageCollector elimina el objeto en memoria
        /// </summary>
        public void Clear() {
            startNode.Value = default(int);
            startNode.Next = null;
        }

        public bool IsEmpty() {
            if (startNode.Next == null)
                return true;
            else
                return false;
        }

        public Node Search(int value) {
            if (IsEmpty())
                return null;
            //Trabajo al Inicio
            workNode = startNode;
            while (workNode.Next != null)
            {
                //Avanzamos trabajo
                workNode = workNode.Next;

                if (workNode.Value == value)
                    return workNode;
            }
            return null;
        }
        public int SearchIndex(int value) {
            int n = -1;
            if (IsEmpty())
                return n;

            //Trabajo al Inicio
            workNode = startNode;
            while (workNode.Next != null)
            {
                //Avanzamos trabajo
                workNode = workNode.Next;
                n++;
                if (workNode.Value == value)
                    return n;
            }
            return -1;
        }


        /// <summary>
        /// Encontrar el nodo anterior
        /// Si esta en el primer nodo se regresa al ancla</summary>
        /// Si el dato no existe se regresa el ultimo nodo<param name="valor"></param>
        /// <returns></returns>
        public Node GetBeforeNode(int value)
        {
            workNode = startNode;
            while (workNode.Next != null && workNode.Next.Value != value) 
            {
                workNode = workNode.Next; 
            }
            return workNode;
        }

        /// <summary>
        /// Encontrar el nodo anterior
        /// Si esta en el primer nodo se regresa al ancla</summary>
        /// Si el dato no existe se regresa Null<param name="valor"></param>
        /// <returns></returns>
        public Node GetBeforeNoderCustom(int value)
        {
            workNode = startNode;
            Node beforeNode = null;
            bool exist = false;
            while (workNode.Next != null)
            {
                beforeNode = workNode;
                workNode = workNode.Next;
                if (workNode.Value == value) {
                    exist = true;
                    break;
                }
            }
            if (exist)
                return beforeNode;
            else
               return null;

        }
        public void Delete(int value) {
            if (IsEmpty())
                return;

            // es una referencia al nodo anterior, una referencia no un nuevo objeto
            Node beforeNode = GetBeforeNode(value);
            // es una referencia al nodo buscado, una referencia no un nuevo objeto
            Node nodeToReplace = Search(value);

            if (nodeToReplace == null)
                return;

            //brincamos el nodo
            beforeNode.Next = nodeToReplace.Next;
            /// desconectamos este nodo de la lista ligada
            nodeToReplace.Next = null;
        }
        public void DeleteCustom(int value)
        {
            if (IsEmpty())
                return;


            //Trabajo al Inicio
            workNode = startNode;
            // es una referencia al nodo anterior, una referencia no un nuevo objeto
            Node beforeNode = null;
            // es una referencia al nodo buscado, una referencia no un nuevo objeto
            Node NonodeToReplacede = null;

            while (workNode.Next != null)
            {
                beforeNode = workNode;
                //Avanzamos trabajo
                workNode = workNode.Next;
                if (workNode.Value == value) {
                    NonodeToReplacede = workNode;
                    break;
                }
                 
            }

            beforeNode.Next = NonodeToReplacede.Next;
            /// desconectamos este nodo de la lista ligada
            NonodeToReplacede = null;
        }

        public void InsertNode(int nodeWhereInsert, int Value) {
            // buscar Index
            workNode = Search(nodeWhereInsert);

            if (workNode == null)
                return;
            Node tempNode = new Node();
            tempNode.Value = Value;

            // conectamos el temporal a la lista
            tempNode.Next = workNode.Next;

            // conectamos workNode al temporal
            workNode.Next = tempNode;
        }

        public void InsertStart(int value) {

            //Trabajo al Inicio
            workNode = startNode;

            Node tempNode = new Node();
            tempNode.Value = value;
            // conectamos el temporal a la lista
            tempNode.Next = workNode.Next;
            // conectamos workNode al temporal
            workNode.Next = tempNode;


        }

        public Node GetByIndex(int index) {

            int iterator = -1;
            workNode = startNode;
            // se avanza hasta el nodo nulo
            while (workNode.Next != null)
            {
                workNode = workNode.Next;
                iterator++;
                if (iterator == index)
                    return workNode;
            }
            return null;
        }

        /// <summary>
        /// esto se llama INDEXER
        /// para hacerle set o get a un objeto
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public int? this[int indice]
        {
            get
            {
                workNode = GetByIndex(indice);
                if (workNode != null)
                    return workNode.Value;
                else
                    return null;
            }
            set
            {
                workNode = GetByIndex(indice);
                if (workNode != null)
                {
                    workNode.Value = Convert.ToInt32(value);
                }
            }
        }
    }
}
