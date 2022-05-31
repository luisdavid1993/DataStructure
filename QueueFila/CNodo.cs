using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFila
{
  public  class CNodo
    {
        // Aquí colocamos el dato o datos que guarda el nodo
        private int dato;
        // Esta variable de referencia es usada para apuntar al nodo siguiente
        private CNodo siguiente = null;
        // Propiedades que usaremos
        public int Valor { get => dato; set => dato = value; }
        internal CNodo Siguiente { get => siguiente; set => siguiente = value; }
        // Para su fácil impresión
        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
