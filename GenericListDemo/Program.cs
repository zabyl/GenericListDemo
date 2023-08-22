using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();

            numList.Add(1);
            numList.Add(2);
            numList.Add(3);
            numList.Add(4);

            List<string> colorList = new List<string>();
            colorList.Add("red");
            colorList.Add("blue");
            colorList.Add("yellow");


            Console.WriteLine(colorList.Count);
            Console.WriteLine(numList.Count);

            foreach (int num in numList)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            foreach (string color in colorList)
            {
                Console.Write(color + " ");
            }

            Console.WriteLine();
            numList.ForEach(num => Console.WriteLine(num));
            colorList.ForEach(color => Console.WriteLine(color));

            numList.Remove(3);
            colorList.Remove("blue");

            Console.WriteLine();
            numList.ForEach(num => Console.WriteLine(num));
            colorList.ForEach(color => Console.WriteLine(color));

            Console.WriteLine();

            string[] animals = {"cat", "dog", "lion" };
            List<string> animalList = new List<string>(animals);

            animalList.Clear();




            Console.ReadLine();
        }
    }
}
