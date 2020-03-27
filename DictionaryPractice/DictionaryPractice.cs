using System;
using System.Collections.Generic;

namespace DictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //English to Spanish dictionary
            Dictionary<string, string> engspaDict = new Dictionary<string, string>();
            //Putting things inside dictionary
            engspaDict.Add("Monday", "Lunas");
            engspaDict.Add("Tuesday", "Martes");
            engspaDict.Add("Wednesday", "Miercoles");
            engspaDict.Add("Thursday", "Jueves");
            engspaDict.Add("Friday", "Viernes");
            engspaDict.Add("Saturday", "Sabado");
            engspaDict.Add("Sunday", "Domingo");

            //Retrieve things from dictionary
            Console.WriteLine(engspaDict.ContainsKey("Monday"));
            Console.WriteLine(engspaDict.ContainsKey("Tuesday"));
            Console.WriteLine(engspaDict.ContainsKey("Wednesday"));
            Console.WriteLine(engspaDict.ContainsKey("Thursday"));
            Console.WriteLine(engspaDict.ContainsKey("Friday"));
            Console.WriteLine(engspaDict.ContainsKey("Saturday"));
            Console.WriteLine(engspaDict.ContainsKey("Sunday"));


            //printing dictionary values by using keys
            string test;
            if (engspaDict.TryGetValue("Monday", out test))
            {
                Console.WriteLine(test);
            }

            foreach (var pair in engspaDict)
            {
                Console.WriteLine(pair.Value);
            }

            Console.WriteLine(engspaDict.GetValueOrDefault("Monday"));
            Console.WriteLine(engspaDict.GetValueOrDefault("Tuesday"));
            Console.WriteLine(engspaDict.GetValueOrDefault("Wednesday"));
            Console.WriteLine(engspaDict.GetValueOrDefault("Thursday"));
            Console.WriteLine(engspaDict.GetValueOrDefault("Friday"));
            Console.WriteLine(engspaDict.GetValueOrDefault("Saturday"));
            Console.WriteLine(engspaDict.GetValueOrDefault("Sunday"));

            //print out all keys
            Console.WriteLine("Print out all keys");
            Dictionary<string, string>.KeyCollection keyColl = engspaDict.Keys;
            foreach (string s in keyColl)
            {
                Console.WriteLine(s);
            }

            //Print out all values
            Console.WriteLine("Print out all values");
            Dictionary<string, string>.ValueCollection coll = engspaDict.Values;
            foreach (string v in coll)
            {
                Console.WriteLine(v);
            }

            //Print out size
            Console.WriteLine($"The sixe of our dictionary is : {engspaDict.Count}");

            Console.WriteLine();
            Console.WriteLine();
            //Shopping list
            Dictionary<string, Boolean> shoppingList = new Dictionary<string, Boolean>();
            //put some stuff in dictionary
            shoppingList.Add("Ham", true);
            shoppingList.Add("Bread", true);
            shoppingList.Add("Oreos", false);
            shoppingList.Add("Sugar", false);
            shoppingList.Add("Eggs", true);


            Console.WriteLine(shoppingList.GetValueOrDefault("Ham"));
            Console.WriteLine(shoppingList.GetValueOrDefault("Sugar"));
            Console.WriteLine(shoppingList.EnsureCapacity(5));
            shoppingList.Add("Snaks", false);
            //Key-Value pair printouts

            foreach (KeyValuePair<string, Boolean> pair in shoppingList)
            {
                Console.WriteLine($"{pair.Key}, {pair.Value}");
            }

            //shoppingList.Clear();
            //Console.WriteLine("Dictionary has these things after clearing up");

            shoppingList.Remove("Ham");



            foreach (KeyValuePair<string, Boolean> pair in shoppingList)
            {
                Console.WriteLine($"Dictionary has these things after clearing up {pair.Key}, {pair.Value}");
            }


        }
    }
}