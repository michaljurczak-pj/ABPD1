using System;

namespace APBD1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            double average = CalculateAverage(numbers);
            Console.WriteLine($"Average: {average}");

            int[] numbers2 = { 3, 7, 2, 9, 1 };
            int max = FindMax(numbers2);
            Console.WriteLine($"Max: {max}");
        }

        static double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0)
                return 0;

            double total = 0;
            foreach (var number in numbers)
            {
                total += number;
            }
            return total / numbers.Length;
        }

        static int FindMax(int[] numbers)
        {
            if (numbers.Length == 0)
                throw new InvalidOperationException("Array is empty");

            int max = numbers[0];
            foreach (var number in numbers)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }
    }
}
