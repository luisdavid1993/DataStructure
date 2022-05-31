using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReHashHash.Interfaces
{
  public interface IHashFunction
    {
       int HashFunction(int prmKey, int prmTryNumber, int prmLeng);
    }
}
