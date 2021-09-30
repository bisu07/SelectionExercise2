using System;

namespace SwitchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter your favourite subject:");
            string subject = "math";
            switch(subject)
            {
                case "science":
                    Console.WriteLine("scinece");
                    break;
                case "biology":
                    Console.WriteLine("biology");
                    break;
                case "math":
                    Console.WriteLine("math");
                    break;
                case "history":
                    Console.WriteLine("history");
                    break;
                case "arts":
                    Console.WriteLine("arts");
                    break;
                default:
                    break;

            }

        }
    }
}
