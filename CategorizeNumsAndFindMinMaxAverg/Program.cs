namespace CategorizeNumsAndFindMinMaxAverg
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static void Main()
        {
            var readLine = Console.ReadLine();
            var floatNumber = new List<float>();
            var number = new List<double>();

            if (readLine != null)
            {
                string[] array =
                    readLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();


                foreach (var s in array)
                {
                    if (InegerNumberTrue(s))
                    {
                        number.Add(double.Parse(s));
                    }
                    else
                    {
                        floatNumber.Add(float.Parse(s));
                    }
                }
            }

            Console.WriteLine(
                $"Floating number Min: {floatNumber.Min():f2}\nFloating number Max: {floatNumber.Max():f2}\nFloating number Average: {floatNumber.Average():f2}\n\n"
                + $"Int number Min: {number.Min():f2}\nInt number Max: {number.Max():f2}\nInt number Average: {number.Average():f2}");

        }

        static bool InegerNumberTrue(string number)
        {
            int floatingPointIndex = number.IndexOf('.');
            if (floatingPointIndex == -1)
            {
                return true;
            }

            for (int i = floatingPointIndex + 1; i < number.Length; i++)
            {
                if (number[i] != '0')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
