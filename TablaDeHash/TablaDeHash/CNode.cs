using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaDeHash
{
   public class CNode
    {
        private int ckey;
        private string cvalue;
        private CNode cnext = null;

        public CNode() {
            CNext = null;
        }
        public CNode(int prmCkey, string prmcValue)
        {
            Ckey = prmCkey;
            CValue = prmcValue;
            CNext = null;
        }

        public int Ckey { get { return ckey; } set { ckey = value; } }
        public string CValue { get { return cvalue; } set { cvalue = value; } }
        public CNode CNext { get { return cnext; } set { cnext = value; } }

        public override string ToString()
        {
            return $"{Ckey},{CValue}";
        }

    }
}
