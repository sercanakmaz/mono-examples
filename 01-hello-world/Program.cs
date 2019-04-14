using System;

namespace ReportingService.Api
{
    class Program
    {
        public static void Main(params string[] args)
        {
            System.Console.Write("Enter your name: ");
            
            var name = Console.ReadLine();

            Console.WriteLine("Hello to mono world, {0}", name);
        }
    }
}
