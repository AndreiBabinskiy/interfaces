using System;

namespace Laba7_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Letter letters = new Letter(32);
            foreach(char letter in letters.MyItr(-20,35))
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine("\n");

            WorkDay workDays = new WorkDay();
            foreach(string workDay in workDays.MyWorkDay(2, 10))
            {
                Console.Write(workDay + " ");
            }
            Console.WriteLine();
        }
    }
}
