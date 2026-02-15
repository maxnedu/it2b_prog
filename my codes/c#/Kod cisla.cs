using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Console.Write("Write number: ");
            int number = int.Parse(Console.ReadLine());
            int partOfNumber, sum = 0;
            do
            {
                partOfNumber = number % 10;

                number = number / 10;

                if(partOfNumber % 2 == 0)
                {
                    sum -= partOfNumber;
                } else
                {
                    sum += partOfNumber;
                }

            }while(number > 1 );

            if(sum < 0)
            {
                sum = Math.Abs(sum);
            }

            Console.WriteLine(sum);

           

        }
    }
}
