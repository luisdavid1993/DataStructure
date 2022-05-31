using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFila
{
   public class CQueue
    {

        CNodo ancla;
        // Esta variable de referencia nos ayuda trabajar con la cola
        CNodo trabajo;

        public CQueue()
        {
            // Instanciamos el ancla
            ancla = new CNodo();
            // Cómo es una cola vacia su siguiente es null
            ancla.Siguiente = null;
        }

        public void Transversa()
        {
            // Trabajo al inicio
            trabajo = ancla;
            while (trabajo.Siguiente != null)
            {
                // Avanzamos trabajo
                trabajo = trabajo.Siguiente;
                Console.Write("<=={0} ", trabajo.Valor);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Inserta siempre en la ultima posición
        /// </summary>
        /// <param name="dato"></param>
        public void Enqueue(int dato)
        {
            // Trabajo al inicio
            trabajo = ancla;
            // Recorremos hasta encontrar el final
            while (trabajo.Siguiente != null)
            {
                // Avanzamos trabajo hasta el final
                trabajo = trabajo.Siguiente;
            }
            // Creamos el nuevo elemento de cola
            CNodo newEnCola = new CNodo();
            // Insertamos el dato
            newEnCola.Valor = dato;
            // El nuevo elemento apuntará a nulo ultimo nodo actual
            newEnCola.Siguiente = null;
            // El ultimo de la cola apuntará al nuevo ultimo
            trabajo.Siguiente = newEnCola;
        }

        /// <summary>
        /// obtiene el primer valor de la fila y lo elimina
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            // Esta version no contiene código de seguridad
            // Colocar una excepción cuando se intente hacer un Dequeue cuando el queue está vacío
            int valor = 0;
            // Llevamos a cabo el trabajo solo si hay elementos en la cola
            if (ancla.Siguiente != null)
            {
                // Obtenemos el dato correspondiente
                trabajo = ancla.Siguiente;
                valor = trabajo.Valor;
                // Lo sacamos del queue
                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }
            return valor;
        }
        /// <summary>
        /// obtiene el primer valor de la fila
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            // Esta version no contiene código de seguridad
            // Colocar una excepción cuando se intente hacer un Peek cuando el queue está vacío
            int valor = 0;
            // Llevamos a cabo el trabajo solo si hay elementos en la cola
            if (ancla.Siguiente != null)
            {
                // Obtenemos el dato correspondiente
                trabajo = ancla.Siguiente;
                valor = trabajo.Valor;
            }
            return valor;
        }
    }
}
