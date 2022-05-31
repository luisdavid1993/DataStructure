using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaDeHash
{
  public class CList
    {
        public CNode cNodeRoot;
        private CNode cNodeWork;
        public CList() {
            cNodeRoot = new CNode();
        }

        /// <summary>
        ///  I moved to the last List Position then I Insert
        /// </summary>
        /// <param name="prmCkey"></param>
        /// <param name="prmCvalue"></param>
        public void insert(int prmCkey, string prmCvalue) {
            cNodeWork = cNodeRoot;
            while (cNodeWork.CNext != null)
            {
                cNodeWork = cNodeWork.CNext;
            }
            cNodeWork.CNext = new CNode(prmCkey, prmCvalue);
        }

        public void Transeverse() {
            cNodeWork = cNodeRoot;
            while (cNodeWork.CNext != null)
            {
                cNodeWork = cNodeWork.CNext;
                Console.WriteLine(cNodeWork.ToString());
            }
        }

        public CNode Search(int prmCkey) {
            cNodeWork = cNodeRoot;
            while (cNodeWork.CNext != null)
            {
                cNodeWork = cNodeWork.CNext;
                if (cNodeWork.Ckey == prmCkey)
                    return cNodeWork;
            }
            return null;
        }

        public void Delete(int prmCkey) {
            if (IsEmpty())
                return;

            //I get the before Node
            CNode tempNode = GetBefore(prmCkey);
            if (tempNode != null) {
                //cNodeWork is equal to the node to delete
                cNodeWork = tempNode.CNext;
                //the node before is equal to the node to delete dot(point) next
                tempNode.CNext = cNodeWork.CNext;
                cNodeWork = null;
                tempNode = null;
            }
        }

        public bool IsEmpty()
        {
            if (cNodeRoot.CNext == null)
                return true;
            else
                return false;
        }
        public CNode GetByIndex(int prmIndex) {
            int index = -1;
            cNodeWork = cNodeRoot;
            while (cNodeWork.CNext != null) {
                index++;
                if (prmIndex == index) {
                    return cNodeWork;
                }
               cNodeWork = cNodeWork.CNext;
            }


                return null;
        }

        /// <summary>
        /// INDEXER
        /// set o get object
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public int? this[int indice]
        {
            get
            {
                cNodeWork = GetByIndex(indice);
                if (cNodeWork != null)
                    return cNodeWork.Ckey;
                else
                    return null;
            }
            set
            {
                cNodeWork = GetByIndex(indice);
                if (cNodeWork != null)
                {
                    cNodeWork.Ckey = Convert.ToInt32(value);
                }
            }
        }
        private CNode GetBefore(int prmCkey)
        {
            cNodeWork = cNodeRoot;
            CNode temp = null;
            while (cNodeWork.CNext != null)
            {
                temp = cNodeWork;
                 cNodeWork = cNodeWork.CNext;
                if (cNodeWork.Ckey == prmCkey)
                    return temp;
            }
            return null;
        }
    }
}
