using System;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string userInput = Console.ReadLine();
            //do
            //{
                //Console.WriteLine("Hey cna you write something");

                //string response = Console.ReadLine(); 

            //    if (true)
            //{
            //    //then this line of code


            //}
            //else
            //{
            //    //then this 


            //}

            //int switchnumber = 0; 

            //switch(switchnumber)
            //{
            //    case 1: Console.WriteLine("case one");
            //        break;
            //    case 5: Console.WriteLine("case 5 ");
            //        break;
            //    default:
            //        break;


            //}

            ////explict 
            //double number = 22.50;
            //int secondnumber = (int)number;

            ////implict
            //int thirdNumber = 3;
            //double num = thirdNumber; 


            ////while loop as long as the booleen is true it will continue to exec 
            //while(num < 5)
            //{
            //    Console.WriteLine("I just want a loop");
            //    num++;

            //}

            //while(false)
            //{
            //    Console.WriteLine("Never ending ");

            //}

            //do
            //{

            //    Console.WriteLine("I will exec at least once");


            //} while (false);

            //int secondnumer2 = 0;

            //do

            //{

            //    Console.WriteLine("exec as long as I want ");
            //    secondnumer2++;

            //} while (secondnumer2 <= 5);

            //// want to keep looping until the user tells me no (N) 

           
            //    Console.WriteLine("loopdie loop");
            //    userInput = Console.ReadLine();
               
            //} while (userInput != "N"); 


   


            int[] array = new int[]
            {

                1,2,3,4,5

            };
            for (int j = 0; j < 5; ++j)
            {
                Console.WriteLine(j);
            }

            for (int i = 0; i < array.Length; ++i) 
            {
                Console.WriteLine(array[i]);
            }

         }
    }
}
