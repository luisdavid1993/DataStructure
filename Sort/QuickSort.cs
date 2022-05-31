using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   public  class QuickSort
    {
        private List<int> ListToSort = null;

        public QuickSort(List<int> prmListToSort) {
            ListToSort = prmListToSort;
        }
        public  List<int> Sort() {
            int pInicio = 0;
            int pFin = ListToSort.Count - 1;

            quickSort(pInicio, pFin);
            return ListToSort;
        }

        public  void quickSort(int pInicio, int pFin)
        {
            int iPivote = 0;
            // Caso base, un elemento o fragmento inválido
            if (pInicio >= pFin) 
            { 
                return; 
            }
            // Obtenemos el indice del pivote para el fragmento con el que trabajamos
            iPivote = Particion(pInicio, pFin);
            // Casos inductivos
            quickSort(pInicio, iPivote - 1); // Fragmento a la izquierda del pivote
            quickSort(iPivote + 1, pFin); // Fragmento a la derecha del pivote
        }

        private  int Particion(int pInit, int pFin)
        {
            int pivote = 0;
            int iPivote = 0;

            // Seleccionamos el ultimo como pivote
            pivote = ListToSort[pFin];
            // Ponemos el indice de pivote con el indice de inicio
            iPivote = pInit;
            // Recorremos la lista en el indice n es menor o igual al pivote
            for (int i = pInit; i < pFin; i++)
            {
                // Si el elemento en el indice es menor o igual al pivote
                if (ListToSort[i] <= pivote)
                {
                    Swap(i, iPivote);
                    // Incrementamos el indice del pivote
                    iPivote++;
                }
            }
            // Hacemos el swap final para colocar el pivote donde corresponde
            Swap(iPivote, pFin);
            // Regresamos el indice del pivote
            return iPivote;
        }


        /// <summary>
        /// Change position
        /// </summary>
        /// <param name="arrayToOrder"></param>
        /// <param name="i1"> Position a asignate to i2</param>
        /// <param name="i2">Position a asignate to i1</param>
        private  void Swap(int i1, int i2)
        {
            int temp = ListToSort[i1];
            ListToSort[i1] = ListToSort[i2];
            ListToSort[i2] = temp;
        }
        public string ToString(List<int> prmListTo)
        {
            string stringBuilder = string.Empty;
            for (int i = 0; i < 20; i++)
            {
                stringBuilder += prmListTo[i] + " ";
            }

            return stringBuilder;
        }
    }
}
