using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpInDepth
{
    class Program : QueryData
    {
        static void Main(string[] args)
        {
            string[] words = { "zero", "one", "two", "three", "four" };
            int[] numbers = { 0, 1, 2, 3, 4 };

            object[] allStrings = { "These", "are", "all", "strings" };
            object[] notAllStrings = { "Number", "at", "the", "end", 5 };

            List<User> users = new Users().UsersList;
            List<string> onlystring = users.SingleOrDefault().Details.ToLower().Split('\\').OfType<string>().ToList();
            onlystring.ForEach(Console.WriteLine);

            //Creare o colectie enumerabil default ce nu contine nici un element
            //Initializare
            var enumInt = Enumerable.Empty<int>();

            //Atribuire o lista de numere intregi
            enumInt = new List<int>() { 1, 2, 3 };

            //Castarea elementului la o lista de int si afisarea elementelor
            (enumInt as List<int>).ForEach(Console.WriteLine);

            string[] asString = new string[0];

            int index = asString.Length;
            foreach (object word in allStrings)
            {
                Array.Resize(ref asString, index + 1);
                asString[index] = (string)word;
                index++;
            }


            words.GroupJoin(asString,
                word => word[0],
                allString => allString[0],
                (word, matches) => word + ": " + string.Join(";", matches.ToArray())).ToList().ForEach(Console.WriteLine);

            //Procesare Complexa al unui fisier xml cu ajutorul LINQ to XML
            QueryXML();
            Console.Read();
        }

       
    }
}
