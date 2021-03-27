using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicWebForm
{
    public class DataCollection
    {
        public void UseArrayList() 
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(3);
            arrayList.Add(12.45);
            arrayList.Add("Hello");

            arrayList.Insert(2, 12.45);

            arrayList.Remove(1);

            arrayList.Clear();

            arrayList.IndexOf(45);
        }


        public void UseArrayList2()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(3);
            arrayList.Add(12.45);

            for (int i = 0; i < arrayList.Count; i++)
            {
                if (arrayList[i] is int)
                    arrayList[i] = ((int)arrayList[i]) + 3;
            }
        }


        public void UseList()
        {
            List<int> intList = new List<int>();

            intList.Add(3);
            intList.Add(13);
            intList.Add(23);

            intList.Insert(2, 12);

            intList.Remove(1);

            intList.Clear();

            intList.IndexOf(45);

            int val = intList[2];
        }


        public void UseHashTable()
        {
            Hashtable hash = new Hashtable();

            hash.Add(1, "alice");
            hash.Add(2, "alice");
            hash.Add("3", "john");

            hash.ContainsKey(1);

            hash.Remove("3");

            var result = hash[1];
        }

        public void UseDirectory()
        {
            Dictionary<int, string> hash = 
                new Dictionary<int, string>();

            hash.Add(1, "alice");
            hash.Add(2, "alice");
            hash.Add(3, "john");

            hash.ContainsKey(1);

            hash.Remove(3);

            var result = hash[1];
        }
    }
}