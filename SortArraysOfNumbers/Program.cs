namespace SortArraysOfNumbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var readLine = Console.ReadLine();
            
            if (readLine != null)
            {
                int[] array = readLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                Array.Sort(array);

                foreach (var i in array)
                {
                    Console.Write("{0}", i);
                }
            }
        }
    }
}
