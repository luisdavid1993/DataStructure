using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBinaryTree
{
  public class BinaryTree
    {

        private NodeTree _root;
        public BinaryTree()
        {
            _root = null;
        }


        //public  NodeTree Insert(int data)
        //{
        //    // Si no hay a quién insertar entonces creamos el nodo
        //    if (pNode == null)
        //    {
        //        NodeTree temp = new NodeTree();
        //        temp.Data = data;
        //        return temp;
        //    }
        //    // Si el dato es menor
        //    if (data < pNode.Data)
        //    {
        //        pNode.Left = Insert(pNode.Left, data);
        //    }
        //    // Si el dato es mayor
        //    if (data > pNode.Data)
        //    {
        //        pNode.Right = Insert(pNode.Right, data);
        //    }

        //    return pNode;
        //}

        ///// <summary>
        ///// Root,Left,Right
        ///// </summary>
        //public  void preOrder(NodeTree pNode)
        //{
        //    if (pNode == null)
        //        return;

        //    Console.Write(pNode.Data + " ");
        //    // Si tengo izquierda, proceso a la izquierda
        //    if (pNode.Left != null)
        //    {
        //        preOrder(pNode.Left);
        //    }
        //    // Si tengo a la derecha, proceso a la derecha
        //    if (pNode.Right != null)
        //    {
        //        preOrder(pNode.Right);
        //    }
        //}

       
    }
}
