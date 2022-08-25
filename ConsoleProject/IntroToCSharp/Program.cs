using System;

namespace AIE
{
    class Project
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Cameron Danitschek");

            //Variable TYPE NAME (value)
            int age = 18;

            Console.WriteLine(age);

            Console.WriteLine("What is your favorite peice of candy?");
            string favCandyInput = Console.ReadLine();
            Console.WriteLine("Your favorite candy is " + favCandyInput);

            if(favCandyInput== "Crunch")
            {
                Console.WriteLine("Crunch? Not bad not bad.");
            }

            string numberInput = Console.ReadLine();
            int userNumber = 0;
            int.TryParse(numberInput, out userNumber);
            Console.WriteLine("You wrote the number " + userNumber);
            Console.WriteLine("If squared, it would be " + userNumber * userNumber);

        }

        
    }
}

