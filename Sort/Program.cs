using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        // buscar numero menor que falta en una lista ordenada
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int[] arrayToOrder = new int[15000];//{ 2, 4, 6, 1, 5, 8, 3 };//{ 3,15,7,19,11,1 };

            for (int i = 0; i < arrayToOrder.Length; i++)
            {
                int num = rnd.Next(1, 100000);
                arrayToOrder[i] = num;
            }

            Stopwatch stopWatch5 = new Stopwatch();

            QuickSort quickSort = new QuickSort(arrayToOrder.ToList());
            stopWatch5.Start();
            Console.WriteLine(quickSort.ToString(quickSort.Sort()));
            stopWatch5.Stop();
            Console.WriteLine("QuickSort :" + stopWatch5.Elapsed);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine(Sorts.BubbleSort(arrayToOrder).ToStringS());
            stopWatch.Stop();
            Console.WriteLine("burbueja : " + stopWatch.Elapsed);

            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            Console.WriteLine(Sorts.SelectionSort(arrayToOrder).ToStringS());
            stopWatch2.Stop();
            Console.WriteLine("SelectionSort :" + stopWatch2.Elapsed);


            Stopwatch stopWatch3 = new Stopwatch();
            stopWatch3.Start();
            Console.WriteLine(arrayToOrder.OrderBy(x => x).ToArray().ToStringS());
            stopWatch3.Stop();
            Console.WriteLine("liq :" + stopWatch3.Elapsed);

            ////int[] arrayOne = { 1, 2, 3, 4, 5, 9, 10, 12, 13, 14, 16, 17 };
            ////int[] arrayTwo = { 1, 3, 7, 11, 15, 19, 20, 21 };

            ////Console.WriteLine(Sorts.MergeSort(arrayTwo.ToList(), arrayOne.ToList()).ToArray().ToStringS());


            ////int[] arrayMergeSort = { 3, 15, 7, 19, 11, 1 };

            Stopwatch stopWatch4 = new Stopwatch();
            stopWatch4.Start();
            Console.WriteLine(Sorts.MergeSortMethod(arrayToOrder.ToList()).ToArray().ToStringS());
            stopWatch4.Stop();
            Console.WriteLine("MergeSortMethod :" + stopWatch4.Elapsed);






            Console.WriteLine("*****************************************");



            Console.ReadLine();
        }
    }
}
