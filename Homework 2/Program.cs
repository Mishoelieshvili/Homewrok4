using System;
using System.Drawing;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Press Enter");
            var someword = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(someword + "misho elieshvili");

        }
    }
}
