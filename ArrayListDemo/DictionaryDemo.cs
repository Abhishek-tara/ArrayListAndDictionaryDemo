using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    //Dictionary is a genric collection that consist of elements.
    //As key value pair.
    //It's not in sorted order.
    public class DictionaryDemo
    {
        Dictionary <string,string> namesList = new Dictionary <string,string> ();
        public void Methods()
        {
            namesList.Add("1", "Abhi");
            namesList.Add("2", "Bruce");
            namesList.Add("3", "Stark");
            namesList.Add("4", "Stark");//Duplicate value
            // Console.WriteLine(namesList["1"]);
            //Updating value
            namesList["1"] = "Jarvis";
            //Remove
            //namesList.Remove("1");

            if (namesList.ContainsKey("4"))
            {
                namesList["4"] = "Clark";
            }
            //Clear --> Removes all
            namesList.Clear();

            foreach(KeyValuePair <string,string> pair in namesList)
            {
                Console.WriteLine (pair.Key + " : " + pair.Value);
            }
        }
    }
}
