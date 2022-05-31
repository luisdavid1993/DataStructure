using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBinaryTree
{
    public class NodeTree
    {
        private int data;
        private NodeTree left;
        private NodeTree right;

        public NodeTree()
        {
            this.data = 0;
            this.left = null;
            this.right = null;
        }

        public NodeTree(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }


        public int Data { get => data; set => data = value; }
        public NodeTree Left { get => left; set => left = value; }
        public NodeTree Right { get => right; set => right = value; }
    }
}
