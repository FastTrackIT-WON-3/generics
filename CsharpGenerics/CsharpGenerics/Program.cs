using System;
using System.Collections.Generic;

namespace CsharpGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            VariableHelper.Swap<int>(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            string s1 = "first";
            string s2 = "second";
            VariableHelper.Swap<string>(ref s1, ref s2);
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Tuple<int, int> tupleFrequencies = new Tuple<int, int>
            {
                FirstElement = 1,
                SecondElement = 2
            };

            Tuple<string, string> tupleTranslations = new Tuple<string, string>
            {
                FirstElement = "Hello world",
                SecondElement = "Buna lume"
            };

            Tuple<int, string, decimal> tupleProduct = new Tuple<int, string, decimal>
            {
                FirstElement = 1,
                SecondElement = "Coca Cola",
                ThirdElement = 7.5M
            };

            Tuple<int, string> converted = tupleProduct;


            List<int> listOfIntegers = new List<int>();
            listOfIntegers.AddRange(new[] { 1, 2, 1, 4 });
            foreach (int element in listOfIntegers)
            {
                Console.WriteLine(element);
            }

            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("test");
            listOfStrings.AddRange(new[] { "two", "three" });
            foreach(string element in listOfStrings)
            {
                Console.WriteLine(element);
            }




        }
    }
}
