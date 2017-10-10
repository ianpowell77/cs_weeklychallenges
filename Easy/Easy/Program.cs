using System;

namespace Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer...");

            try{
				int userInput = Convert.ToInt16(Console.ReadLine());

				if (userInput < 10)
				{
					Console.WriteLine("That number is too small.");
				}
				else
				{
					Console.WriteLine("That number is big enough.");
				}
            } catch(Exception)
                {
                    Console.WriteLine("Please enter a valid number.");
                }

        }
    }
}
