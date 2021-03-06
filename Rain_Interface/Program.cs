﻿using System;

namespace Rain_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int option = 0;
            while (option == 0)
            {
                try
                {
                    Console.Clear();
                    Screen.Main_Screen();
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.Clear();
                            Screen.Functions();
                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Internal Error " + e.Message);
                                option = 0;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Screen.Options();
                            try
                            {
                                option = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Internal Error " + e.Message);
                                option = 0;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ending...");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Internal Error " + e.Message);
                    option = 0;
                }
                break;
            }
        }
    }
}
