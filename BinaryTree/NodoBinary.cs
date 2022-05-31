using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
  public class NodoBinary
    {
        private int dato;
        private NodoBinary izq;
        private NodoBinary der;

        public NodoBinary()
        {
            this.dato = 0;
            this.izq = null;
            this.der = null;
        }

        public int Dato { get => dato; set => dato = value; }
        public NodoBinary Izq { get => izq; set => izq = value; }
        public NodoBinary Der { get => der; set => der = value; }
    }

    public class Cnode   {

        public Cnode() {
            NodeBase = null;
            Position = 1;
        }
        public Cnode(NodoBinary nodeBase, int position)
        {
            NodeBase = nodeBase;
            Position = position;
        }

        public NodoBinary NodeBase { get; set; }
        public int Position { get; set; }
    }
}
