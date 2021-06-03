using System;

namespace Lecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            var userinput = Console.ReadLine();
            var result = Factorial(userinput);
            Console.WriteLine(result);

        }


        public static long Factorial(string numberOne)
        {
          
 
                var convertedNumber = int.Parse(numberOne);
                for (int i = 1; i < convertedNumber; ++i)
                {
                1 *=  i;

                }

            int result = convertedNumber;
            return convertedNumber;
        }


    }
}


