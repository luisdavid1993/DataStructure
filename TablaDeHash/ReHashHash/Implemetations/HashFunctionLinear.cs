using ReHashHash.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReHashHash.Implemetations
{
   public class HashFunctionLinear : IHashFunction
    {
    public int HashFunction(int prmKey, int prmTryNumber, int prmLeng)
        {
            int index = 0;
            //Linear Probing
            index = (prmKey + prmTryNumber) % prmLeng;
            return index;
        }
    }
}
