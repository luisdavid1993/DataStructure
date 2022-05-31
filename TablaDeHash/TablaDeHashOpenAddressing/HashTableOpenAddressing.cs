using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaDeHashOpenAddressing
{
    /// <summary>
    ///Si hay colisión en la mayoria de los casos obtenemos la celda siguiente
    /// Sondeo Lineal (Linear Probing) hi(x) = (h(x) + i) % n
    /// Sondeo Cuadratico (Quadratic Probing) hi(x) = (h(x) + ixi) % n
    /// </summary>
    /// 

    public class HashTableOpenAddressing
    {
        private int Leng = 11;
        public CCell[] CTable;
        IHashF HashFunction = null;

        public HashTableOpenAddressing(IHashF prmHash) 
        {
            this.HashFunction = prmHash;
            CTable = new CCell[Leng];
            for (int n = 0; n < Leng; n++)
                CTable[n] = new CCell();
        }

        public void Insert(int prmKey, string prmValue) 
        {
            int counter = 0;
            int index = 0;
            bool isBusy = false;
            while (isBusy == false) 
            {
                index = HashFunction.HashF(prmKey, counter, Leng);
                if (CTable[index].CState != State.Busy)
                {
                    isBusy = true;
                    CTable[index] = new CCell(prmKey, prmValue, State.Busy);
                }
                else {
                    counter++;
                }
            }
        }

        public void Show()
        {
            for (int i = 0; i < Leng; i++)
            {
                Console.WriteLine($"{i} [{CTable[i].CKey}, {CTable[i].CValue}]");
            }
        }

    }
   public interface IHashF {
        int HashF(int prmKey, int prmTryNumber, int prmLeng);
    }

    public class HashFunctionLinear : IHashF
    {
        int IHashF.HashF(int prmKey, int prmTryNumber, int prmLeng)
        {
            int index = 0;
            //Linear Probing
            index = (prmKey + prmTryNumber) % prmLeng;
            return index;
        }
    }

    public class HashFunctionQuadratic : IHashF
    {
        int IHashF.HashF(int prmKey, int prmTryNumber, int prmLeng)
        {
            int index = 0;
            //Quadratic Probing
            index = (prmKey + (prmTryNumber * prmTryNumber)) % prmLeng;
            return index;
        }
    }
}
