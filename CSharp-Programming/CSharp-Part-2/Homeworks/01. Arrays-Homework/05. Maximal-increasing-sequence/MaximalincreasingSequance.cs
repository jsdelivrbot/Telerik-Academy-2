﻿namespace _05.Maximal_increasing_sequence
{
    using System;

    class MaximalincreasingSequance
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];
            int currentSequence = 1;
            int maxSequence = 0;

            for (int i = 0; i < length; i++)
            {
                int el = int.Parse(Console.ReadLine());
                array[i] = el;
            }

            for (int j = 1; j < length; j++)
            {
                if (array[j] >= (array[j - 1]) + 1)
                {
                    currentSequence++;
                    maxSequence = Math.Max(maxSequence, currentSequence);
                }
                else
                {
                    currentSequence = 1;
                }
            }

            Console.WriteLine(maxSequence);
        }
    }
}
