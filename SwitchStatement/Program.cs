using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your favorite subjct");

            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject)
            {
                case "MO":
                    Console.WriteLine("I love Math");
                    break;
                case "EN":
                    Console.WriteLine("I love English");
                    break;
                default:
                    Console.WriteLine("Nothing");
                    break;
            }

        }
    }
}
