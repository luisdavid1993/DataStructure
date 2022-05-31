using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapProject
{
   public class Heap
    {
        private int capacidad;
        private int tamanio;
        private int[] elementos;

        public Heap(int prmCapacidad) {
            this.capacidad = prmCapacidad;
            elementos = new int[capacidad + 1];
        }

        public void Transversa() {
            for (int i = 0; i <= tamanio; i++)
                Console.Write($" {elementos[i]} ,");
            Console.WriteLine();
        }

        public bool EstaLleno() {
            return tamanio >= capacidad;
        }

        public void Insertar(int prmValor) {
            int i = 0;
            if (EstaLleno())
            {
                return;
            }
            else {
                for (i = tamanio +1;elementos[i/2] > prmValor; i /=2)
                {
                    elementos[i] = elementos[i / 2];
                }
                elementos[i] = prmValor;
                tamanio++;
            }
        }

        public int BorrarMin() {
            int n = 0;
            int hijo = 0;
            int elementoMenor = 0;
            int ultimoElemento = 0;

            if (EstaLleno()) {
                return 0;
            }
            elementoMenor = elementos[1];
            ultimoElemento = elementos[tamanio--];
            for (n = 1; n*2 <= tamanio; n=hijo)
            {
                // encontramos el menor
                hijo = n * 2;
                if (hijo != tamanio && elementos[hijo + 1] < elementos[hijo]) {
                    hijo++;
                }

                //percolamos
                if (ultimoElemento > elementos[hijo])
                {
                    elementos[n] = elementos[hijo];
                }
                else {
                    break;
                }
            }
            //actualizamos
            elementos[n] = ultimoElemento;
            //regresamos el menor
            return elementoMenor;
        }
    }
}
