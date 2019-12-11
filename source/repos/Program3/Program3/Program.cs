using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_n = 0;
            int number_f = 0;

            for (int number_k = -41; number_k >= -121; number_k--)
            {
                number_n = number_n + number_k;
                number_f++;
            }

            Console.WriteLine("Ответ = {0}",
                number_n / number_f); ;
            Console.ReadKey();
        
        }
    }
}
