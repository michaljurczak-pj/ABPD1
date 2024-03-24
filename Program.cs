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
        }

        static double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0)
                return 0;

            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }
    }
}
