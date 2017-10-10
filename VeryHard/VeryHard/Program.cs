using System;

namespace VeryHard
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string conversionType;
            double output;

            Console.WriteLine("Please enter a number you'd like to convert...");

            try
            {
                number = Convert.ToInt16(Console.ReadLine());

                if(number < 1)
                {
                    Console.WriteLine("Enter a number above 0");
                    return;
                }

                Console.Clear();

				Console.WriteLine("Specify the conversion, you would like to perform by inputting I, G, M, or P.");
				Console.WriteLine("I -> convert inches to centimeters.");
				Console.WriteLine("G -> convert from gallons to liters.");
				Console.WriteLine("M -> convert from mile to kilometer.");
				Console.WriteLine("P -> convert from pound to kilogram.");

				conversionType = Console.ReadLine();

                Console.Clear();

				switch (conversionType.ToUpper().Trim())
				{
					case "I":
                        output = number * 2.54;
						Console.WriteLine("{0} inches is {1} centimeters.", number, output);
						break;
					case "G":
                        output = number * 3.78;
						Console.WriteLine("{0} gallons is {1} liters.", number, output);
						break;
					case "M":
                        output = number * 1.6;
                        Console.WriteLine("{0} miles is {1} kilometers.", number, output);
						break;
					case "P":
                        output = number * .5;
						Console.WriteLine("{0} pounds is {1} kilograms.", number, output);
						break;
					default:
                        Console.WriteLine("Invalid measurement input");
                        break;
				}
            } catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
