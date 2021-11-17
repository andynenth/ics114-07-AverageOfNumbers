using System;

namespace AverageOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SAMPLE_SIZE = 10;

            int[] number = new int[SAMPLE_SIZE];

            int total = 0;

            for (int i = 0; i <= SAMPLE_SIZE-1; i++)
            {
                Console.Write(" Enter a number #{0}: ", i + 1);

                string inVal = Console.ReadLine();

                if (!int.TryParse(inVal, out number[i]))
                {
                    Console.WriteLine(" Your input of \"{0}\" is invalid. Will use zero instead.", inVal);
                }

                total += number[i];
            }

            Console.WriteLine(" Average of number is {0:F1}", (float)total / SAMPLE_SIZE);
        }
    }
}
