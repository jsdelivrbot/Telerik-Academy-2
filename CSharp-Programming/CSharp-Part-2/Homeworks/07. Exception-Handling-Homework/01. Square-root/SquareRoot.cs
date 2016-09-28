﻿namespace _01.Square_root
{
    using System;

    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                double number = double.Parse(Console.ReadLine());

                if (double.IsNaN(Math.Sqrt(number)))
                {
                    throw new Exception();
                }

                Console.WriteLine("{0:F3}", Math.Sqrt(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
