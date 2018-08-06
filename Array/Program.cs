using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates array up to 6
            int[] numbers = new int[6];

            //Assigning array to these values.
            numbers[0] = 1;
            numbers[1] = 1;
            numbers[2] = 2;
            numbers[3] = 3;
            numbers[4] = 5;
            numbers[5] = 8;

            //Telling console to print array with the assigned values.
            foreach (int item in numbers) { Console.WriteLine(item); }
            Console.ReadLine();
        }
    }
}
