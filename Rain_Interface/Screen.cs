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
            int X = int.Parse(Console.ReadLine());
            if (X == 1)
            {
                
            }
            if (X == 2)
            {
                Console.Clear();
                Calculator();
            }
            if (X == 3)
            {

            }
            if (X == 4)
            {

            }
            if (X == 5)
            {
                Console.Clear();
                Main_Screen();
            }
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
            Console.WriteLine("5 - Back");
            Console.Write("Your Choice: ");
            int X = int.Parse(Console.ReadLine());
            if (X == 1)
            {
                Console.Clear();
                Console.WriteLine("----Calculator----");
                Sum_Calculator();
                Console.WriteLine("Do you want repeat?");
                Console.WriteLine("1 - Yes");
                Console.WriteLine("2 - No");
                Console.Write("Your choice: ");
                int C = int.Parse(Console.ReadLine());
                if (C == 1)
                {
                    Console.Clear();
                    Sum_Calculator();
                }
                if (C == 2)
                {
                    Console.Clear();
                    Calculator();
                }
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
            if (X == 5)
            {
                Console.Clear();
                Functions();
            }
        }

        public static void Sum_Calculator()
        {
            Console.Write("Enter the first sum value: ");
            int Y = int.Parse(Console.ReadLine());
            Console.Write("Enter the second sum value: ");
            int Z = int.Parse(Console.ReadLine());
            int A = Y + Z;
            Console.WriteLine(Y + " + " + Z + " = " + A);
        }

        public static void Stopwatch()
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("----StopWatch----");
            Console.WriteLine("");
        }
    }
}
