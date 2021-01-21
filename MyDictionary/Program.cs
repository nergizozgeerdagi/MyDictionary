using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        private static bool value;

        static void Main(string[] args)
        {

            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Pencil", "Kurşun Kalem");
            myDictionary.Add("Eraser", "Silgi");
            myDictionary.Add("Pencil Case", "Kalemlik");
           

            foreach (var value in myDictionary.Values)
            {
                Console.WriteLine(value);
            }

            myDictionary.Add("School Bag", "Okul Çantası");
            foreach (var value in myDictionary.Values)
            {
                Console.WriteLine(value);
            }

            myDictionary.Add("Glass", "Bardak");
            foreach (var value in myDictionary.Values)
            {
                Console.WriteLine(value);
            }

            
        }
    }
}