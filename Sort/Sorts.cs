using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class Sorts 
    {

        // =============================================== BubbleSort
        public static int[] BubbleSort(int[] arrayToOrder) {
            int m = 0;
            int n = 0;
            int cantidad = arrayToOrder.Length;
            for (m = 1; m < cantidad; m++)
            {
                for (n = 0; n < cantidad - m; n++)
                {
                    if (arrayToOrder[n] > arrayToOrder[n + 1])
                        arrayToOrder.Swap(n, n + 1);
                }
            }

            return arrayToOrder;
        }

        /// <summary>
        /// Change position
        /// </summary>
        /// <param name="arrayToOrder"></param>
        /// <param name="i1"> Position a asignate to i2</param>
        /// <param name="i2">Position a asignate to i1</param>
        private static void Swap(this int[] arrayToOrder, int i1, int i2) {
            int temp = arrayToOrder[i1];
            arrayToOrder[i1] = arrayToOrder[i2];
            arrayToOrder[i2] = temp;
        }


        // =============================================== InsertionSort

        public static int[] InsertionSort(int[] arrayToOrder)
        {
            //Insertion Sort
            int cantidad = arrayToOrder.Length;
            int indexAgujero = 0;
            int dato = 0;
            int[] lista = arrayToOrder;
            // Ascendente
            //Recorremos los elementos
            for (int i = 1; i < cantidad; i++)
            {
                //Obtenemos el dato
                dato = (int)lista[i];
                //Indicamos la posición del agujero
                indexAgujero = i;
                //Recorremos los elementos hacia el agujero
                while (indexAgujero > 0 && lista[indexAgujero - 1] > lista[indexAgujero])
                {
                    lista.Swap(indexAgujero, indexAgujero - 1);
                    indexAgujero -= 1;
                }
                //Le colocamos al agujero el dato correspondiente
                lista[indexAgujero] = dato;
                //lista.Transversa();
            }
            return lista;
        }


        // =============================================== Selection sort
        public static int[] SelectionSort(int[] arrayToOrder) {
            int cantidad = arrayToOrder.Length;
            int menorIndice = 0;
            //n+1(n+2)= (n)2 + n2
            for (int i = 0; i < cantidad; i++)//n+1
            {
                menorIndice = i;//1
                for (int j = i + 1; j < cantidad; j++)//n+2
                {
                    if (arrayToOrder[j] < arrayToOrder[menorIndice])//1
                    {
                        menorIndice = j;//1
                    }
                }

               arrayToOrder.Swap(i, menorIndice);
            }
            return arrayToOrder;
        }


        // =============================================== Marge sort
        public static List<int>  MergeSort(List<int> arrayOne, List<int> arrayTwo) {
            List<int> arrayToOrder = new List<int>();
            int longitudOne = arrayOne.Count;
            int longitudTwo = arrayTwo.Count;
            int pOne = 0;
            int pTwo = 0;


                while (pOne < longitudOne && pTwo < longitudTwo)
                {
                    if (arrayOne[pOne] < arrayTwo[pTwo])
                    {
                        arrayToOrder.Add(arrayOne[pOne]);
                        pOne++;
                    }
                    else if (arrayOne[pOne] > arrayTwo[pTwo])
                    {
                    arrayToOrder.Add(arrayTwo[pTwo]);
                        pTwo++;
                    }
                    else {
                    arrayToOrder.Add(arrayTwo[pTwo]);
                        pOne++;
                        pTwo++;
                    }
                }

            while (pOne < longitudOne)
            {
                arrayToOrder.Add(arrayOne[pOne]);
                 pOne++;
            }

            while (pTwo < longitudTwo)
            {
                arrayToOrder.Add(arrayTwo[pTwo]);
                pTwo++;
            }

            return arrayToOrder;
        }



        public static  List<int> MergeSortMethod( List<int> lista)
        {
            // Cantidad de elementos en la lista.
            int cantidad = lista.Count;
            // Caso base, una lista de un solo elemento ya está ordenada
            if (cantidad < 2)
            {
                return lista;
            }

            //Obtenemos el punto medio de la lista
            int mitad = cantidad / 2;

             List<int> left = new  List<int>();
             List<int> der = new  List<int>();

            // Adicionamos a la izquierda desde el inicio hasta antes de la mitad
            for (int i = 0; i < mitad; i++)
            {
                left.Add(lista[i]);
            }
            for (int i = mitad; i < cantidad; i++)
            {
                der.Add(lista[i]);
            }

            // Casos Inductivos
            // Hacemos el MergeSort de las listas izquierda y derecha
             List<int> tempoLeft = MergeSortMethod(left);
             List<int> tempoRight = MergeSortMethod(der);

            // Hacemos el merge de lo que nos regresa el caso inductivo
             List<int> ordenado = MergeSort(tempoLeft, tempoRight);

            // Regresamos la lista ordenada
            return ordenado;
        }


        // =============================================== QuickSort sort





        //============================== ToStringS
        public static string ToStringS(this int[] arrayToOrderB)
        {
            string stringBuilder = string.Empty;
            for (int i = 0; i < 20; i++)
            {
                stringBuilder += arrayToOrderB[i] + " ";
            }

            return stringBuilder;
        }
    }
}
