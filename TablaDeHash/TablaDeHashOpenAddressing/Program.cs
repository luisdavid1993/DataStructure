using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaDeHashOpenAddressing
{
    class Program
    {
        static void Main(string[] args)
        {
            IHashF hashFunction = new HashFunctionQuadratic();
            HashTableOpenAddressing hash = new HashTableOpenAddressing(hashFunction);
            hash.Insert(23,"Hola");
            hash.Insert(51, "Manzana");
            hash.Insert(40, "Pera");
            hash.Insert(62, "Mango");
            hash.Show();
            Console.ReadLine();
        }
    }
}
