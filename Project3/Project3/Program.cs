using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            string lastinput = null;



            while (lastinput != "n")
            // Continue asking until a correct answer is given.
            {

                Console.WriteLine("Enter a Number between 1 and 100");

                var unit = Console.ReadLine();
                var canBeParsed = int.TryParse(unit, out int result);



                // var number = Int32.TryParse(unit, out int result);


                if (canBeParsed)
                 {

                if (result <= 100 && result >= 0)
                    {
                        if (result % 2 == 0 && result <= 25)
                        {
                            Console.WriteLine(name+ "," + result + " is an even number and less then 25");
                        }
                        if (result % 2 == 0 && result >= 26 && result <= 60)
                        {

                            Console.WriteLine(name+ "," + result + " is an even number and less then 60");

                        }
                        if (result % 2 == 0 && result >= 60)
                        {

                            Console.WriteLine(name + "," + unit + " is an even number and greater then 60");

                        }
                        if (result % 2 != 0 && result >= 60)
                        {

                            Console.WriteLine(name + "," + unit + " is an odd number and greater then 60");

                        }
                        if (result % 2 != 0 && result <= 60)
                        {
                            Console.WriteLine(name + "," + unit + " is an odd number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }


                    //lastinput = answer;

                    while (true) // Continue asking until a correct answer is given.
                    {
                        Console.WriteLine("Continue (y/n)");
                        string answer = Console.ReadLine().ToLower();

                        if (answer == "n")
                        {
                            Console.WriteLine("bye!");
                            return;
                        }
                        else
                        if (answer == "y")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("I don't understand, try again");
                            break;

                        }
                    }


                }
                else {

                    Console.WriteLine("you didn't give me a number");


                }
            }
        }

        
    }
}
