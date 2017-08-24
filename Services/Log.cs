using System;

namespace Robot.Services
{
    public class Log
    {
        public static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(DateTime.Now.ToString() + " ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("INFO ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message);
        }
    }
}