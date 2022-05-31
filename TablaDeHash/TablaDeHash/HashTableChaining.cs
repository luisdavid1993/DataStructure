using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaDeHash
{
    /// <summary>
    /// Module is the residue of division 
    /// 57%10 = 7 because 57/10 is equal to 5 en the remainder is 7
    /// </summary>
    /// <param name="args"></param>
    /// 



    /// <summary>
    /// this used Chaining for solving collisions 
    /// </summary>
    /// <param name="args"></param>
    public class HashTableChaining
    {
        private  int Leng = 10;
        public CList[] CTable;

        public HashTableChaining() {
            CTable = new CList[Leng];
            for (int n = 0; n < Leng; n++)
                CTable[n] = new CList();
        }

        public  void Show()
        {
            for (int n = 0; n < Leng; n++)
            {
                Console.Write($"({n}) : ");
                CTable[n].Transeverse();
                Console.WriteLine();
            }
        }

        public int HashF(int prmKey)
        {
            return prmKey % Leng;
        }

        public void Insert(int prmKey, string prmValue)
        {
            int index = HashF(prmKey);
            CTable[index].insert(prmKey, prmValue);
        }

        public CList Find(int prmKey)
        {
            int index = HashF(prmKey);
            return (CList)CTable[index];
        }
        public void Delete(int prmKey)
        {
            int index = HashF(prmKey);
            CTable[index] = new CList();
        }

    }
}
