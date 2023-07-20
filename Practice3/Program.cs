using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Program
    {
        public static void SecondMaxNumber(int[] arr)
        {
            int firstHighest = arr[0], secondHighest = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > firstHighest)
                {
                    secondHighest = firstHighest;
                    firstHighest = arr[i];
                }
                else if (arr[i] > secondHighest)
                {

                    secondHighest = arr[i];
                }
            }
            Console.Write("Second highest element: ");
            Console.WriteLine(secondHighest);
        }

        public static bool FindDupplicate(int[] number)
        {
            int firstNumber = number[0];
            Console.WriteLine("Find Dupplicate: ");
            for (int i = 1; i < number.Length; i++)
            {
                if (number[i] != firstNumber)
                {
                    firstNumber = number[i];
                    Console.WriteLine($"number({i}) = {number[i]} True");
                }
                else
                {
                    Console.WriteLine($"number({i}) = {number[i]} False");
                }
            }
            return true;
        }

        public static int ReverseNumber(int a)
        {
            int sum = 0;
            while (a != 0)
            {
                int b = a % 10;
                a = a / 10;
                sum = sum * 10 + b;
            }
            Console.Write("Reverse number: ");
            return sum;
        }

        static void Main(string[] args)
        {
            
                int[] arr = new int[5];
                arr[0] = 28;
                arr[1] = 16;
                arr[2] = 75;
                arr[3] = 5;
                arr[4] = 5;
                SecondMaxNumber(arr);
                Console.WriteLine("-----------------------");

                Console.WriteLine(ReverseNumber(458));
                Console.WriteLine("-----------------------");
                FindDupplicate(arr);
                Console.ReadKey();
            

        }
    }
}
