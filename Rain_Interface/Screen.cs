using System;
using System.Collections.Generic;
using System.Text;

namespace Rain_Interface
{
    class Screen
    {
        public static void Main_Screen()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("--------Welcome To RAIN--------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Started at: " + DateTime.Now);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Type what you want do");
            Console.WriteLine("1 - Functions");
            Console.WriteLine("2 - Options");
            Console.WriteLine("3 - Exit");
            Console.Write("Your Choice: ");
        }

        public static void Functions()
        {
            Console.WriteLine("----Functions----");
            Console.WriteLine("1 - Send Email");
            Console.WriteLine("2 - Calculator");
            Console.WriteLine("3 - Stopwatch");
            Console.WriteLine("4 - Music Player");
            Console.WriteLine("5 - Back to Main Menu");
            Console.Write("Your Choice: ");
        }

        public static void Options()
        {
            Console.WriteLine("----Options----");
            Console.WriteLine("1 - Language");
            Console.WriteLine("2 - Set Time");
            Console.Write("Your Choice: ");
        }
    }
}
