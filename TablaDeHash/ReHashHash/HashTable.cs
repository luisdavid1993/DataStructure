using ReHashHash.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReHashHash
{
    public class HashTable
    {
        private int Leng;
        private int Inserted;
        public RCell[] CTable;
        IHashFunction HashType;

        public HashTable(IHashFunction prmHash, int prmLeng = 11)
        {
            this.HashType = prmHash;
            this.Leng = prmLeng;
            this.Inserted = 0;
            CTable = new RCell[Leng];
            for (int n = 0; n < Leng; n++)
                CTable[n] = new RCell();
        }

        public void Insert(int prmKey, string prmValue)
        {
            int counter = 0;
            int index = 0;
            bool isBusy = false;
            while (isBusy == false)
            {
                index = HashType.HashFunction(prmKey, counter, Leng);
                if (CTable[index].CState != State.Busy)
                {
                    CTable[index] = new RCell(prmKey, prmValue, State.Busy);
                    Inserted++;
                    isBusy = true;
                }
                else
                {
                    counter++;
                }
            }

            if (Inserted >= (double)Leng * 0.7) {
                Console.WriteLine($"-------- Rehash insertados : {Inserted} longitud : {Leng}");
                ReHash();
            }
        }

        public void Show()
        {
            for (int i = 0; i < Leng; i++)
            {
                Console.WriteLine($"{i} [{CTable[i].CKey}, {CTable[i].CValue}]");
            }
        }
        public int NearCousing(int position) {
            int nearCousin = 0;
            bool found = false;
            int positionDouble = (position * 2);
            while (found == false) {
                int startDivisor = 2;

                while (startDivisor <= positionDouble) {
                    if (positionDouble % startDivisor != 0)
                    {
                        startDivisor++;
                    }
                    else 
                    {
                        if (startDivisor == positionDouble)
                        {
                            found = true;
                            nearCousin = positionDouble;
                        }
                        break;
                    }
                }

                if (found == false)
                    positionDouble++;

            }
            return nearCousin;
        }
        private void ReHash()
        {
            int newLeng = NearCousing(Leng);
            int beforeLeng = Leng;
            
           

            RCell[] temp = new RCell[newLeng];
            for (int n = 0; n < newLeng; n++)
                temp[n] = new RCell();

            //actualizamos la variable al nuevo tamaño
            Leng = newLeng;

            //recorremos la tabla vieja y vamos insertando en la nueva
            for (int i = 0; i < beforeLeng; i++)
            {
                int counter = 0;
                bool isBusy = false;
                if (CTable[i].CState == State.Busy) 
                {
                    RCell tempRcell = new RCell(CTable[i].CKey, CTable[i].CValue, CTable[i].CState);

                    while (isBusy == false) {
                        int index = HashType.HashFunction(tempRcell.CKey, counter, Leng);

                        if (temp[index].CState != State.Busy)
                        {
                            temp[index] = tempRcell;
                            isBusy = true;
                        }
                        else
                        {
                            counter++;
                        }

                    }

                }
            }

            CTable = (RCell[])temp.Clone();
        }
    }

}
