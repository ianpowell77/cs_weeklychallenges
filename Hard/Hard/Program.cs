using System;

namespace Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i <= 5)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }

                for(int k = 0; k < (2*i)-1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                i++;
            }
        }
    }
}
