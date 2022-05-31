using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas
{
  public  class Node
    {
        //Aquí colocamos el dato o datos que guarda el nodo.
        public int Value { get; set; }
        //Esta variable de referencia es usada para apuntar al nodo siguiente
        public Node Next = null;
    }
}
