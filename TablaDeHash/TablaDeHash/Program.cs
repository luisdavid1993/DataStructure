using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaDeHash
{
    class Program
    {
        
        static void Main(string[] args)
        {


            //Dictionary<int,List<CNode>> openWith = new Dictionary<int, List<CNode>>();
            //openWith[1] = new List<CNode>();
            //openWith[1].Add(new CNode(1, "hola begin"));
            //openWith[7] = new List<CNode>();
            //openWith[7].Add(new CNode(7, "hola"));
            //openWith[7].Add(new CNode(17, "mundo"));

            //var xxx = openWith.Values;
            //foreach (KeyValuePair<int,List<CNode>> item in openWith) {
            //    int yyy = 0;
            //}


            HashTableChaining hash = new HashTableChaining();
            hash.Insert(3, "hola");
            hash.Insert(7, "mundo");
            hash.Insert(10, "genial");
            hash.Insert(15, "tes");
            hash.Insert(17, "test2");
            hash.Show();
            Console.WriteLine("--------");


            CList tempCList = hash.Find(7);
            Console.WriteLine("-------- Find start");
            tempCList.Transeverse();
            Console.WriteLine("-------- Find end");


            hash.Delete(7);
            hash.Show();
            Console.WriteLine("--------");
            Console.ReadLine();
        }

        //CList clist = new CList();
        //clist.insert(3,"hola");
        //clist.insert(7, "mundo");
        //clist.insert(10, "genial");
        //clist.insert(15, "tes");
        //clist.insert(17, "test2");

        //CNode temp =  clist.GetByIndex(3);
        //clist[1] = 2;
        //clist.Transeverse();
        
    }
}
