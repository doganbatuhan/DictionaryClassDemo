using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();

            myDictionary.Add("Türkiye", "Ankara");
            myDictionary.Add("Almanya", "Berlin");
            myDictionary.Add("İngiltere", "Londra");
            myDictionary.Add("Rusya", "Moskova");

            Console.WriteLine("Sözlükte toplam " + myDictionary.Count() + " eleman var.");
            Console.WriteLine(myDictionary.GetValue("Rusya"));
            Console.WriteLine(myDictionary.GetKey("Ankara"));

            Console.ReadLine();

        }
    }
}
