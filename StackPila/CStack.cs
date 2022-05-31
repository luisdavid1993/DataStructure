using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPila
{
  public  class CStack
    {
        // Es el ancla o encabezado del stack
        private CNodo ancla;
        // Esta variable de referencia nos ayuda a trabajar con el stack
        private CNodo trabajo;

        public CStack()
        {
            this.ancla = new CNodo();
            this.trabajo = null;
        }

        /// <summary>
        /// Inserta un dato siempre al incio
        /// </summary>
        /// <param name="dato"></param>
        public void Push(char dato) {
            CNodo temp = new CNodo();
            temp.Dato = dato;
            // Conectamos el temporal a la lista 
            //pila actual a,b,c el twmporal lo conectamos a "a"
            temp.Siguiente = ancla.Siguiente;
            // Conectamos el ancla al temporal
            // colocamos el temporal en la posición 0 siempre
            ancla.Siguiente = temp;

        }

        /// <summary>
        /// obtiene el primer dato pero tambien lo elimina
        /// </summary>
        /// <returns></returns>
        public char Pop() {

            char valor = ' ';
            if (ancla.Siguiente != null) {
                //conectamos trabajo al primer valor 
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

                // avanzamos el ancla para saltarnos el primer valos
                ancla.Siguiente = trabajo.Siguiente;
                //eliminamos las coneciones de trabajo
                trabajo.Siguiente = null;
            }
            return valor;
        }

        /// <summary>
        /// obtiene el dato sin eliminarlo
        /// </summary>
        /// <returns></returns>
        public char Peek() {

            char valor = ' ';
            if (ancla.Siguiente != null) {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
            }
            return valor;
        }

        /// <summary>
        /// recorreo la pila
        /// </summary>
        public void Transversa() {

            trabajo = ancla;
            while (trabajo.Siguiente != null) {

                trabajo = trabajo.Siguiente;
                int d = trabajo.Dato;
                Console.WriteLine("[{0}]", d);
            }
        }

        // Cantidad de Elementos
        public bool IsEmpty()
        {
            if (ancla.Siguiente == null)
                return true;
            else
                return false;
        }
    }
}
