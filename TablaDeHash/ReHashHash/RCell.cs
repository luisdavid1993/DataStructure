using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReHashHash
{
    public enum State
    {
        Empty,
        Busy,
        Deleted
    }
  public class RCell
    {
        public int CKey { get; set; }
        public string CValue { get; set; }
        public State CState { get; set; }

        public RCell()
        {
            CKey = 0;
            CValue = string.Empty;
            CState = State.Empty;
        }

        public RCell(int prmKey, string prmValue, State prmState)
        {
            this.CKey = prmKey;
            this.CValue = prmValue;
            this.CState = prmState;
        }
    }
}
