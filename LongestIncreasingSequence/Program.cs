using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSequence
{
    public class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split().Select(int.Parse).ToArray();

            int counter = 1;
            int maxLength = 1;
            int end = 0;

            Console.Write(numbers[0] + " ");
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    counter++;
                    Console.Write(numbers[i] + " ");
                }
                else
                {
                    counter = 1;
                    Console.WriteLine();
                    Console.Write(numbers[i] + " ");
                }
                if (counter > maxLength)
                {
                    maxLength = counter;
                    end = i;
                }
            }

            Console.WriteLine();
            Console.Write("Longest: ");
            for (int j = end - maxLength + 1; j <= end; j++)
            {
                Console.Write(numbers[j] + " ");
            }

            Console.WriteLine();
        }
    }
}
//string input = Console.ReadLine();
//int[] numbers = input.Split().Select(int.Parse).ToArray();
//List<int> collection = new List<int>();
//int counter = 0;
//int max = 1;

//for (int i = 0; i < numbers.Length - 1; i++)
//{
//    if (numbers[i] < numbers[i + 1])
//    {
//        collection.Add(numbers[i]);
//        counter++;
//        if (max < counter)
//        {
//            max = counter;
//        }
//    }
//}
