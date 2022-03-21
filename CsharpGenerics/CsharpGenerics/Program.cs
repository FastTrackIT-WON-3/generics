using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CsharpGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> listOfRectangles = new List<Rectangle>(
                new[]
                {
                    new Rectangle(10, 20),
                    new Rectangle(30, 40)
                });

            Shape s = new Rectangle(10, 20);
            // List<Rectangle> NU DERIVA DIN List<Shape>!!!
            // Covarianta (out):
            // Generic<Derived> => Generic<Base>
            IEnumerable<Shape> listOfShapes = listOfRectangles;

            // Contravarianta (in):
            // Generic<Base> => Generic<Derived>
            IObjectMover<Shape> shapeMover = new ObjectMover<Shape>();
            IObjectMover<Rectangle> rectangleMover = shapeMover;
            rectangleMover.MoveObjects(10, 20, new Rectangle(10, 20));

            double sumAreas = ShapeCalculator.SumAreas(listOfShapes);
            Console.WriteLine(sumAreas);

            Person p1 = new Person("123")
            {
                FirstName = "John",
                LastName = "Doe"
            };

            Person p2 = new Person("123")
            {
                FirstName = "John",
                LastName = "Doe"
            };

            Person p3 = Factory.Create<Person>();

            p1.Print();
            p2.Print();
            p3.Print();
            VariableHelper.Swap(ref p1, ref p2);
            p1.Print();
            p2.Print();

            MyCollection<int> collectionOfInt = new MyCollection<int>(1, 2, 3, 4);
            Console.WriteLine(collectionOfInt[0]);

            foreach (int element in collectionOfInt)
            {
                Console.WriteLine(element);
            }
        }

        private static void Example_With_GenericClasses()
        {
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
            foreach (string element in listOfStrings)
            {
                Console.WriteLine(element);
            }
        }

        private static void Example_With_GenericMethods()
        {
            int a = 10;
            int b = 20;
            VariableHelper.Swap<int>(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            //string s1 = "first";
            //string s2 = "second";
            //VariableHelper.Swap<string>(ref s1, ref s2);
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
        }
    }
}
