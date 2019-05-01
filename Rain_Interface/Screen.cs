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
            int X = int.Parse(Console.ReadLine());
            if (X == 1)
            {

            }
        }

        public static void Calculator()
        {
            Console.WriteLine("----Calculator----");
            Console.WriteLine("Enter the operation you want to do.");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.Write("Your Choice: ");
            int X = int.Parse(Console.ReadLine());
            if (X == 1)
            {
                Console.Write("Enter the first sum value: ");
                int Y = int.Parse(Console.ReadLine());
                Console.Write("Enter the second sum value: ");
                int Z = int.Parse(Console.ReadLine());
                int A = Y + Z;
                Console.WriteLine(Y + " + " + Z + " = " + A);
            }
            if (X == 2)
            {
                Console.Write("Enter the first subtraction value: ");
                int Y = int.Parse(Console.ReadLine());
                Console.Write("Enter the second subtraction value: ");
                int Z = int.Parse(Console.ReadLine());
                int A = Y - Z;
                Console.WriteLine(Y + " - " + Z + " = " + A);
            }
            if (X == 3)
            {
                Console.Write("Enter the first multiplication value: ");
                int Y = int.Parse(Console.ReadLine());
                Console.Write("Enter the second multiplication value: ");
                int Z = int.Parse(Console.ReadLine());
                int A = Y * Z;
                Console.WriteLine(Y + " * " + Z + " = " + A);
            }
            if (X == 4)
            {
                Console.Write("Enter the first division value: ");
                int Y = int.Parse(Console.ReadLine());
                Console.Write("Enter the second division value: ");
                int Z = int.Parse(Console.ReadLine());
                int A = Y / Z;
                Console.WriteLine(Y + " / " + Z + " = " + A);
            }
        }

        public static void Stopwatch()
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("----StopWatch----");
            Console.WriteLine("");
        }
    }
}
