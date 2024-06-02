using System;

namespace _2.Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli Atama
            int x = 3;
            int y = 4;

            y = y + 2;
            y += 2;
            y /= 3;
            x *= 2;

            //Console.WriteLine(y);
            //Console.WriteLine(x);

            // Mantıksal
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && !isCompleted)
            {
                isSuccess = false;
                isCompleted = true;
            }

            int a = 3;
            int b = 4;
            bool result = a < b;
            Console.WriteLine(result);



        }
    }
}
