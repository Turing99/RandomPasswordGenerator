using System;
using TextCopy;

namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============Welcome to Random Password Generator================");
            Console.WriteLine("How long should the password be?");

            int size = 0;

            while (size <= 5)
            {
                int.TryParse(Console.ReadLine(), out size);
                if (size <= 5)
                {
                    Console.WriteLine("Please insert a numeric value higher or equal to 5");
                }
            }

            string password = Generator.Generate(size);
            ClipboardService.SetText(password);
            Console.WriteLine("Your password has been generated and copied to clipboard");
            Console.WriteLine("========================================================");
            Console.WriteLine(password);
            Console.Read();
        }
    }
}
