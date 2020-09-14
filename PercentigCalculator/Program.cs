using System;

namespace PercentageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Maximum;
            int UserScore;
            double Result;

            Console.WriteLine("What is the maximum score?");
            Maximum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is your score?");
            UserScore = Int32.Parse(Console.ReadLine());
            Result = (UserScore * 100) / Maximum;

            Console.WriteLine($"You scored {Result}%.");
            /* > 90% - 5
             * > 80% - 4
             * > 61% - 3
             * - 2
             */
            if (Result >= 90)
            {
                Console.WriteLine("Your grade is a 5");
            } else if(Result >= 80 && Result <= 89)
            {
                Console.WriteLine("Your grade is a 4");
            } else if (Result >= 61 && Result <= 70)
            {
                Console.WriteLine("Your grade is a 3");
            } else
            {
                Console.WriteLine("Your grade is a 2");
            }
        }
    }
}
