using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
   public class TreeBinary
    {
        private NodoBinary raiz;
        private NodoBinary trabajo;
        private int i = 0;

        public TreeBinary() {
            raiz = null;
        }

        internal NodoBinary Raiz { get => raiz; set => raiz = value; }

        public NodoBinary Insertar(int pDato, NodoBinary pNodo) {
            NodoBinary temp = null;
            // Si no hay a quién insertar entonces creamos el nodo
            if (pNodo == null)
            {
                temp = new NodoBinary();
                temp.Dato = pDato;
                return temp;
            }
            // Si el dato es menor
            if (pDato < pNodo.Dato) 
            { 
                pNodo.Izq = Insertar(pDato, pNodo.Izq); 
            }
            // Si el dato es mayor
            if (pDato > pNodo.Dato) 
            {
                pNodo.Der = Insertar(pDato, pNodo.Der); 
            }

            return pNodo;
        }

        /// <summary>
        /// Preorder (R-I-D)
        /// </summary>
        /// <param name="nodo"></param>
        public void TransversaPreorder(NodoBinary nodo)
        {
            if (nodo == null) {
                return;
            }
            // Me proceso primero a mí
            for (int n = 0; n < i; n++) { 
                Console.Write(" ");
            }
            Console.WriteLine(nodo.Dato);
            // Si tengo izquierda, proceso a la izquierda
            if (nodo.Izq != null)
            {
                i++;
                Console.Write("I ");
                TransversaPreorder(nodo.Izq);
                i--;
            }
            // Si tengo a la derecha, proceso a la derecha
            if (nodo.Der != null)
            {
                i++;
                Console.Write("D ");
                TransversaPreorder(nodo.Der);
                i--;
            }
        }

        public NodoBinary EncuentraMinimo(NodoBinary pNodo) {
            if (pNodo == null)
                return null;

            trabajo = pNodo;
            while (trabajo.Izq != null) {
                trabajo = trabajo.Izq;
            }

            return trabajo;
        }

        public NodoBinary EncontrarMaximo(NodoBinary pNodo) {
            if (pNodo == null)
                return null;

            trabajo = pNodo;
            while (trabajo.Der != null)
            {
                trabajo = trabajo.Der;
            }

            return trabajo;
        }
        /// <summary>
        /// Inorder (I-D-R)
        /// </summary>
        /// <param name="nodo"></param>
        public void TransversaInorder(NodoBinary pNodo) {
            if (pNodo == null)
                return;

            // Si tengo izquierda, proceso a la izquierda
            if (pNodo.Izq != null)
            {
                i++;
                TransversaInorder(pNodo.Izq);
                i--;
            }
            Console.Write("{0}, ", pNodo.Dato);
            if (pNodo.Der != null)
            {
                i++;
                TransversaInorder(pNodo.Der);
                i--;
            }
        }
        public void TransversaPostorder(NodoBinary pNodo)
        {
            if (pNodo == null)
                return;

            // Si tengo izquierda, proceso a la izquierda
            if (pNodo.Izq != null)
            {
                i++;
                TransversaPostorder(pNodo.Izq);
                i--;
            }
           
            if (pNodo.Der != null)
            {
                i++;
                TransversaPostorder(pNodo.Der);
                i--;
            }

            Console.Write("{0}, ", pNodo.Dato);
        }

        public NodoBinary BuscarPadre(int pDato, NodoBinary pNodo) {
            NodoBinary temp = null;

            if (pNodo == null)
                return null;

            //verifico si soy el padre inicio
            if (pNodo.Izq != null)
                if (pNodo.Izq.Dato == pDato)
                    return pNodo;

            if (pNodo.Der != null)
                if (pNodo.Der.Dato == pDato)
                    return pNodo;
            //Soy el padre fin


            if (pNodo.Izq != null && pDato < pNodo.Dato) {
                temp = BuscarPadre(pDato, pNodo.Izq);
            }

            if (pNodo.Der != null && pDato > pNodo.Dato)
            {
                temp = BuscarPadre(pDato, pNodo.Der);
            }

            return temp;
        }

        public NodoBinary BorrarNodo(int pDato, NodoBinary pNodo) {

            if (pNodo == null)
                return null;

            if (pNodo.Dato == pDato)
            {

                if (pNodo.Izq == null && pNodo.Der == null)
                {
                    pNodo = null;
                    return pNodo;
                }
                //  NodoBinary padre = BuscarPadre(pDato, pNodo);
                // si el nodo izquierdo es nulo y el derecho no
                else if (pNodo.Izq == null && pNodo.Der != null)
                {
                    //padre.Der = pNodo.Der;
                    return pNodo.Der;
                }
                // si el derecho es nullo y el izquierdo no
                else if (pNodo.Der == null && pNodo.Izq != null)
                {
                    //  padre.Izq = pNodo.Izq;
                    return pNodo.Izq;
                }
                // si ambos no son nulos
                else {
                    // se buscar el minimo nodo a la derecha
                    NodoBinary minNode = EncuentraMinimo(pNodo.Der);
                    // se asiganan los valores
                    pNodo.Dato = minNode.Dato;
                    // se elimina el nodo con el valor del minimo a la derecha encontrado
                    //se asigna al nodo a la derecha
                    pNodo.Der = BorrarNodo(minNode.Dato, pNodo.Der);
                    return pNodo;
                }
            }


            if (pDato < pNodo.Dato)
            {
                pNodo.Izq = BorrarNodo(pDato, pNodo.Izq);
            }
            if (pDato > pNodo.Dato)
            {
                pNodo.Der = BorrarNodo(pDato, pNodo.Der);
            }

            return pNodo;
        }


        public void BorrarNodo2(int dato, NodoBinary noditoPadre)
        {
           
        }


        public NodoBinary Buscar(int pDato, NodoBinary pNodo)
        {
            if (pNodo == null)
                return null;

            NodoBinary temp = null;

            if (pNodo.Dato == pDato)
                return pNodo;
            else if (pNodo.Dato > pDato)
                temp = Buscar(pDato, pNodo.Izq);
            else if (pNodo.Dato < pDato)
                temp = Buscar(pDato, pNodo.Der);

            return temp;
        }

        public  int height(NodoBinary root)
        {
            // Write your code here.
            if (root == null)
            {
                return 0;
            }
            int jump = 0;
            if (root.Izq != null)
            {
                jump = height(root.Izq) + 1;
            }

            if (root.Der != null)
            {
                jump = height(root.Der) + 1;
            }
            return jump;
        }


        public Queue<int> InorderTransverse(NodoBinary root) {
            Stack<NodoBinary> nodes = new Stack<NodoBinary>();
            Queue<int> nodesReturn = new Queue<int>();
            NodoBinary current = root;
            while (nodes.Count > 0|| current != null)
            {
              
                while (current != null)
                {
                    nodes.Push(current);
                    current = current.Izq;
                }
               
                NodoBinary node = nodes.Pop();
                nodesReturn.Enqueue(node.Dato);
                current = node.Der;

            }
            return nodesReturn;
        }

        public Queue<int> PreOrderTransverse(NodoBinary root)
        {
            Stack<NodoBinary> nodes = new Stack<NodoBinary>();
            Queue<int> nodesReturn = new Queue<int>();
            NodoBinary current = root;
            while (nodes.Count > 0 || current != null)
            {

                while (current != null)
                {
                    nodesReturn.Enqueue(current.Dato);
                    nodes.Push(current);
                    current = current.Izq;
                }

                NodoBinary node = nodes.Pop();
                
                current = node.Der;

            }
            return nodesReturn;
        }

        public List<int> getMaxLeng(List<int> maxLength, NodoBinary root) {

            NodoBinary temp = root;
            NodoBinary tempRight = root;
            List<int> NodeCount = new List<int>();
            while (temp != null)
            {
                NodeCount.Add(temp.Dato);
                temp = temp.Izq;
            }
            while (tempRight != null)
            {
                NodeCount.Add(tempRight.Dato);
                tempRight = tempRight.Der;
            }
            if (NodeCount.Count() > maxLength.Count())
            {
                return NodeCount;
            }
            else
            {
                return maxLength;
            }


        }
        public Dictionary<int, List<int>> TopView(NodoBinary root)
        {
            Stack<Cnode> nDict = new Stack<Cnode>();
            Dictionary<int, List<int>> keyValuePairs = new Dictionary<int, List<int>>();
            NodoBinary current = root;
            Cnode temp = new Cnode();
            bool idRigth = false;
            while (nDict.Count > 0 || current != null)
            {

                while (current != null)
                {
                    if(idRigth)
                        temp = new Cnode(current, temp.Position + 1);
                    else
                        temp = new Cnode(current, temp.Position - 1);

                    nDict.Push(temp);
                    Put(temp.Position, temp.NodeBase.Dato, ref keyValuePairs);

                    current = current.Izq;
                    idRigth = false;

                }

                Cnode node = nDict.Pop();
                current = node.NodeBase.Der;
                temp.Position = node.Position;
                idRigth = true;



            }
            return keyValuePairs;
        }

        public Dictionary<int, List<int>> TopViewBKS(NodoBinary root)
        {
            Stack<Cnode> nDict = new Stack<Cnode>();
            Dictionary<int, List<int>> keyValuePairs = new Dictionary<int, List<int>>();
            NodoBinary current = root;
            Cnode temp = new Cnode();
            bool idRigth = false;
            while (nDict.Count > 0 || current != null)
            {

                while (current != null)
                {
                    if (idRigth)
                        temp = new Cnode(current, temp.Position + 1);
                    else
                        temp = new Cnode(current, temp.Position - 1);

                    nDict.Push(temp);
                    Put(temp.Position, temp.NodeBase.Dato, ref keyValuePairs);

                    current = current.Izq;
                    idRigth = false;

                }

                Cnode node = nDict.Pop();
                current = node.NodeBase.Der;
                temp.Position = node.Position;
                idRigth = true;



            }
            return keyValuePairs;
        }
        public List<int> RealTopView(NodoBinary root) {
            Queue<NodoBinary> qNode = new Queue<NodoBinary>();
            qNode.Enqueue(root);

            while (qNode.Count != 0)
            {
                NodoBinary tmpNode = qNode.Dequeue();
                if (tmpNode.Izq != null)
                {
                    qNode.Enqueue(tmpNode.Izq);
                }
                if (tmpNode.Der != null)
                {
                    qNode.Enqueue(tmpNode.Der);
                }

            }

            return null;
        }

        private void Put(int position, int value, ref Dictionary<int, List<int>> queue) {

                if (queue.ContainsKey(position))
                {
                    queue[position].Add(value);
                }
                else
                {
                    List<int> poQuete = new List<int>();
                    poQuete.Add(value);
                    queue.Add(position, poQuete);
                }
        }
    }
}
