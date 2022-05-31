using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_1
{
    public class Lista_Ligada
    {
        //Es el ancla o encabezado de la lista
        public Nodito ancla;
        //Esta variable de referencia nos ayuda trabajar con la lista.
        private Nodito trabajo;
        // Esta variable de referencia apoya en ciertas operaciones de la lista.
        private Nodito trabajo2;

        public Lista_Ligada()
        {
            //Instanciamos el ancla
            ancla = new Nodito();
            //Cómo es una lista vacía, su siguiente es null
            ancla.setSiguiente(null);
        }

        //Recorre toda la lista
        public void Transversa()
        {
            //Trabajo al Inicio
            trabajo = ancla;
            //Recorremos hasta encontrar el final
            while (trabajo.getSiguiente() != null)
            {
                //Avanzamos trabajo
                trabajo = trabajo.getSiguiente();
                //Obtenemos el dato y lo mostramos
                int d = trabajo.getDato();
                Console.Write("{0} -> ", d);
            }
            //Bajamos la linea
            Console.WriteLine();
        }

        //Agregar nuevo elemento a la lista
        public void Agregar(int valor)
        {
            //Trabajo al Inicio
            trabajo = ancla;
            //Recorremos hasta encontrar el final
            while (trabajo.getSiguiente() != null)
            {
                //Avanzamos trabajo
                trabajo = trabajo.getSiguiente();
            }

            // Creamos el nuevo nodo
            Nodito temporal = new Nodito();
            //Insertemos el dato
            temporal.setDato(valor);
            //Finalizamos correctamente
            temporal.setSiguiente(null);
            //Ligamos el ultimo nodo encontrado con el recien creado
            trabajo.setSiguiente(temporal);
        }

        // Vaciar la lista
        public void Vaciar()
        {
            ancla.setSiguiente(null);
        }

        // Indica si la lista esta vacia o no
        public bool isEmpty()
        {
            if (ancla.getSiguiente() != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // Regresa el nodo con la primera ocurrencia del dato
        public Nodito Buscar(int valor)
        {
            if (isEmpty()) { return null; }
            trabajo2 = ancla;
            //Recorremos para ver si lo encontramos
            while (trabajo2.getSiguiente() != null)
            {
                trabajo2 = trabajo2.getSiguiente();
                //Al encontrarlo lo regresamos...
                if (trabajo2.getDato() == valor) { return trabajo2; }
            }
            //No se encontró, regresamos null
            return null;
        }

        // Regresa el indice del Nodo
        public int getIndice(int valor)
        {
            int n = -1;
            trabajo = ancla;
            while (trabajo.getSiguiente() != null)
            {
                trabajo = trabajo.getSiguiente();
                n++;
                if (trabajo.getDato() == valor) { return n; }
            }
            return -1;
        }

        /*
         * Encontrar el nodo anterior
         * Si esta en el primer nodo se regresa al ancla
         * Si el dato no existe se regresa el ultimo nodo
         */
        public Nodito getNoditoAnterior(int valor)
        {
            trabajo2 = ancla;
            while (trabajo2.getSiguiente() != null && trabajo2.getSiguiente().getDato() != valor) { trabajo2 = trabajo2.getSiguiente(); }
            return trabajo2;
        }

        //Borrar elemento de la lista
        public void borrarElemento(int valor)
        {
            //Verificamos que se tengan datos.
            if (isEmpty()) { return; }
            // Buscamos los nodos con los que trabajaremos
            Nodito anterior = getNoditoAnterior(valor);
            Nodito encontrado = Buscar(valor);
            // Si no hay nodo a borrar, salimos
            if (encontrado == null) { return; }
            //Brincamos el nodo
            anterior.setSiguiente(encontrado.getSiguiente());
            // Quitamos el actual de la lista.
            encontrado.setSiguiente(null);
        }

        // Insertar un valor después de la primera ocurrencia del dato pasado a pDonde
        public void Insertar(int indiceInsercion, int valor)
        {
            // Encontramos la posición donde vamos a insertar
            trabajo = Buscar(indiceInsercion);
            if (trabajo == null) { return; }
            //Creamos el nodo temporal a insertar
            Nodito temporal = new Nodito();
            temporal.setDato(valor);
            //Conectamos el temporal a la lista
            temporal.setSiguiente(trabajo.getSiguiente());
            //Conectamos trabajo a temporal
            trabajo.setSiguiente(temporal);
        }

        //Insertar valor al inicio
        public void insertarInicio(int valor)
        {
            Nodito dato = new Nodito();
            dato.setDato(valor);
            if (isEmpty())
            {
                Agregar(valor);
            }
            else
            {
                dato.setSiguiente(ancla.getSiguiente());
                ancla.setSiguiente(dato);
            }
        }

        //Obtener el nodo que se encuentra en indice especificado
        public Nodito getIndiceNodito(int indice)
        {
            if (isEmpty() || indice > getSize())
            {
                return ancla;
            }

            trabajo = ancla;
            int n = 0;
            while (trabajo.getSiguiente() != null && n != indice)
            {
                trabajo = trabajo.getSiguiente();
                n++;
            }
            return trabajo;
        }
        
        // Obtener el tamaño de elementos...
        public int getSize()
        {
            trabajo = ancla;
            int size = 0;
            while (trabajo.getSiguiente() != null) 
            {
                trabajo = trabajo.getSiguiente();
                size++;
            }
            return size;
        }

        // Indexer ???
        public int? this[int indice]
        {
            get
            {
                trabajo = getIndiceNodito(indice);
                return trabajo.getDato();
            }
            set
            {
                trabajo = getIndiceNodito(indice);
                if (trabajo != null)
                {
                    trabajo.setDato(Convert.ToInt32(value));
                }
            }
        }

        //Comentario
    }
}
