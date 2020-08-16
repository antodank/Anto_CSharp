using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CollectionClass
    {
        public int[] getArray()
        {
            int[] arr = new int[] { 10, 12, 14, 26 };
            return arr;
        }

        public ArrayList getArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Ankit");
            arrayList.Add(45);
            arrayList.Add(55.50);

            return arrayList;
        }

        public Hashtable getHashTable()
        {
            // type unsafe
            Hashtable htb = new Hashtable();
            htb.Add("10", "Ankit");
            htb.Add(11, "Viraj");
            htb.Add("11", "Ram");
            //htb.Add(11, "Shyam"); // will give compile time error

            return htb;
        }

        public HashSet<string> getHashSet()
        {
            string[] names = new string[] {
                "Ram",
                "Shyam",
                "Amar",
                "Raj",
                "Ram",
                "Amit",
                "Amar"
            };

            HashSet<string> hashSet = new HashSet<string>(names);

            hashSet.Add("Amit"); // it wont give error nut it will remove

            // hashSet.UnionWith()

            // hashSet.ExceptWith


            //hashSet.SymmetricExceptWith()  //-- All the matching elements will be removed.


            return hashSet;
        }



    }
}
