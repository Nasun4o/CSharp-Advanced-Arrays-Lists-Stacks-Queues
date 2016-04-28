namespace SortArrayOfNumbersSelectionSort
{
    using System;
    using System.Linq;

    public class Program 
    {
        public static void Main()
        {
            int[] arr = { 2, 11, 4, 33, 23 };
            int min, temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                 min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
