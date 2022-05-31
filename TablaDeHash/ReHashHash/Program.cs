using ReHashHash.Implemetations;
using ReHashHash.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReHashHash
{
    class Program
    {
        static void Main(string[] args)
        {
            IHashFunction hashFunction = new HashFunctionLinear();
            HashTable hashTable = new HashTable(hashFunction);

            hashTable.Insert(23, "Hola");
            hashTable.Insert(51, "Manzana");
            hashTable.Insert(40, "Pera");
            hashTable.Insert(62, "Mango");
            hashTable.Insert(10, "sasa");
            hashTable.Insert(25, "tatata");
            hashTable.Insert(28, "rararara");
            hashTable.Insert(43, "uauauaua");
            hashTable.Show();

            Console.ReadLine();
        }
    }
}
