using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 4, 8, 8, 8, 11, 8 };
            int counter = 1;
            int numberRepetitions = 0;
            int repeatNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    counter++;
                }
                else if (numberRepetitions < counter)
                {
                    numberRepetitions = counter;
                    repeatNumber = array[i - 1];
                    counter = 1;
                }
            }

            Console.WriteLine($"\nЧисло {repeatNumber} повторяется {numberRepetitions} раз подряд");
        }
    }
}


