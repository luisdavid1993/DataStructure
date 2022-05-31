using ReHashHash.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReHashHash.Implemetations
{
    public class HashFunctionQuadratic : IHashFunction
    {
        public int HashFunction(int prmKey, int prmTryNumber, int prmLeng)
        {
            int index = 0;
            //Quadratic Probing
            index = (prmKey + (prmTryNumber * prmTryNumber)) % prmLeng;
            return index;
        }
    }
}
