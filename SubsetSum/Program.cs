using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSum
{
    public class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int[] array = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    for (int k = 0; k < array.Length - 1; k++)
                    {
                        for (int l = 0; l < array.Length - 1; l++)
                        {
                            if (array[i] + array[j] + array[k] + array[l] == num)
                            {
                                Console.WriteLine($"{ array[i]} + { array[j]} + {array[k]} + {array[l]} = { num}");
                            }
                        }
                    }
                }
            }
            Console.WriteLine("No matching subsets");
        }
    }
}
