using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    //ArrayList is a non-generic collection.
    //Stores element of multiple data types
    //size is dynamic in nature.
    //When data type and data size is unknown we can use ArrayList
    public class DemoArrayList
    {
        public void Methods()
        {
            ArrayList arrayList = new ArrayList();
            //Add
            arrayList.Add(10);
            arrayList.Add(20.8);
            arrayList.Add(20.8);
            arrayList.Add(56.8);
            //arrayList.Add("Bruce");

            //Insert
            arrayList.Insert(0, 58);
            //arrayList.Insert(2, "Steve");

            //Remove
            //arrayList.Remove(10);

            //Remove drom index
            //arrayList.RemoveAt(0);

            //Remove from range
            arrayList.RemoveRange(0, 2);

            //Count
            //int count = arrayList.Count;
            //Console.WriteLine("Count" + count);

            //Clear
            //arrayList.Clear();
            //int count = arrayList.Count;
            //Console.WriteLine("Count" + count);

            //Sort
            arrayList.Sort();

            //forloop
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            //foreach
            //foreach(var e in arrayList)
            //{
            //    Console.WriteLine(e);
            //}
        }
       
    }
}
