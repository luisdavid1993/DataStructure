using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
  public  class Node
    {
        public int data;
        public Node left, right;
        public Node() { }

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
    class QueueObj
    {
        public Node node;
        public int hd;

        public QueueObj(Node node, int hd)
        {
            this.node = node;
            this.hd = hd;
        }
    }
   public class BinaryTreeTopView
    {

        Node root;

        public BinaryTreeTopView() { root = null; }

        public Node Insertar(int pDato, Node pNodo)
        {
            Node temp = null;
            // Si no hay a quién insertar entonces creamos el nodo
            if (pNodo == null)
            {
                temp = new Node();
                temp.data = pDato;
                return temp;
            }
            // Si el dato es menor
            if (pDato < pNodo.data)
            {
                pNodo.left = Insertar(pDato, pNodo.left);
            }
            // Si el dato es mayor
            if (pDato > pNodo.data)
            {
                pNodo.right = Insertar(pDato, pNodo.right);
            }

            return pNodo;
        }

        // function should print the topView of
        // the binary tree
      public  void TopView(Node root)
        {
            Queue q = new Queue();
            SortedDictionary<int, Node> topViewMap = new SortedDictionary<int, Node>();

            if (root == null)
            {
                return;
            }
            else
            {
                q.Enqueue(new QueueObj(root, 0));
            }

            // count function returns 1 if the container
            // contains an element whose key is equivalent
            // to hd, or returns zero otherwise.
            while (q.Count != 0)
            {
                QueueObj tmpNode = (QueueObj)q.Dequeue();

                if (!topViewMap.ContainsKey(tmpNode.hd))
                {
                    topViewMap[tmpNode.hd] = tmpNode.node;
                }

                if (tmpNode.node.left != null)
                {
                    q.Enqueue(new QueueObj(tmpNode.node.left,
                                           tmpNode.hd - 1));
                }
                if (tmpNode.node.right != null)
                {
                    q.Enqueue(new QueueObj(tmpNode.node.right,
                                           tmpNode.hd + 1));
                }
            }

            foreach (var entry in topViewMap.Values)
            {
                Console.WriteLine(entry.data);
            }
        }
    }
}
