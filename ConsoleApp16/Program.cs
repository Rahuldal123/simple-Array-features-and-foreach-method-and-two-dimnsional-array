using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5] { 10, 20, 60, 40, 70 };
            int[] num = new int[3];
            string[] st = new string[5] { "Rahul", "sunny", "Mahesh", "Omkar", "Abhishek" };

            foreach (int i in number)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------");
            Array.Sort(number);

            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------");
            Array.Reverse(number);
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------");
            Array.Clear(number, 1, 2);
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------");
            Array.Copy(number, num, 3);
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------");

            int index = Array.IndexOf(number, 40);
            Console.WriteLine($"index of object 40 is {index}");

            foreach (string i in st)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------");
            Array.Sort(st);
            foreach (string i in st)
            {
                Console.Write(i);
            }
            Console.WriteLine("---------------");

            Array.Reverse(st);
            foreach (string i in st)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();



            //Two dimensional Array

            int[,] arr = new int[3, 4]
            {
                {12,13,15,20 },

                {25,30,55,11 },

                {66,65,74,31 }
            };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"number[{i} {j}]={arr[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
