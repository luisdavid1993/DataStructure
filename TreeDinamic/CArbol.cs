using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDinamic
{
    public class CArbol
    {
        private Cnodo raiz;
        private Cnodo trabajo;
        private int i = 0;

        // constructor de nuevo árbol
        public CArbol()
        {
            raiz = new Cnodo();
        }

        public Cnodo Insertar(string cadena, Cnodo nodo)
        {
            // Si no hay nodo donde insertar, tomamos como si fuera en la raiz
            if (nodo == null)
            {
                raiz = new Cnodo();
                raiz.Dato = cadena;
                // No hay hijo
                raiz.Hijo = null;
                // No hay hermano
                raiz.Hermano = null;
                return raiz;
            }
            // Verificamos si no tiene hijo
            if (nodo.Hijo == null)
            {
                Cnodo temp = new Cnodo();
                temp.Dato = cadena;
                // Conectamos el nuevo nodo como hijo
                nodo.Hijo = temp;
                return temp;
            }
            else // Ya tiene un hijo, tenemos que insertarlo como hermano.
            {
                trabajo = nodo.Hijo;
                // Avanzamos hasta el ultimo hermano
                while (trabajo.Hermano != null)
                {
                    trabajo = trabajo.Hermano;
                }
                // Creamos nodo temporal
                Cnodo temp = new Cnodo();
                temp.Dato = cadena;
                // Unimos el temp al último hermano
                trabajo.Hermano = temp;
                return temp;
            }
        }

        public void TransversaPre(Cnodo nodo)
        {
            if (nodo == null)
                return;
            // Me proceseo primero a mí...
            for (int n = 0; n < i; n++)
                Console.Write(" ");

            Console.WriteLine(nodo.Dato);
            // Luego proceso a mi hijo
            if (nodo.Hijo != null)
            {
                i++;
                TransversaPre(nodo.Hijo);
                i--;
            }
            // Si tengo hermanos los proceso
            if (nodo.Hermano != null)
                TransversaPre(nodo.Hermano);
        }

        public void TransversaPost(Cnodo nodo)
        {
            if (nodo == null)
                return;
            // Primero proceso a mi hijo
            if (nodo.Hijo != null)
            {
                i++;
                TransversaPost(nodo.Hijo);
                i--;
            }
            // Si tengo hermanos los proceso
            if (nodo.Hermano != null)
                TransversaPost(nodo.Hermano);
            // Luego me proceso a mí.
            for (int n = 0; n < i; n++)
                Console.Write(" ");
            Console.WriteLine(nodo.Dato);
        }

        public Cnodo Buscar(string valor, Cnodo nodo)
        {
            Cnodo encontrado = null;
            if (nodo == null)
                return encontrado;

            if (nodo.Dato.CompareTo(valor) == 0)
            {
                encontrado = nodo;
                return encontrado;
            }
            // Luego proceso a mi hijo
            if (nodo.Hijo != null)
            {
                // Este encontrado es porque si un nodo no tiene hijo
                // entra al IF  el valor es nulo y luego entra al siguiente IF
                // if (nodo.Hermano != null)
                encontrado = Buscar(valor, nodo.Hijo);
                if (encontrado != null) 
                    return encontrado; 
            }
            // Si tengo hermanos los proceso
            if (nodo.Hermano != null)
            {
                encontrado = Buscar(valor, nodo.Hermano);
                if (encontrado != null) 
                    return encontrado; 
            }

            return encontrado;
        }
    }
}
