﻿using System;
using System.Net.Http;

namespace ProgrammingAssignment1
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 1
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programming Assignment 1
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                

                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }

        static void Code ()
        {
            return;

            string[] elements = new string[] { "H", "He", "Li", "Be", "B", "C", "N", "O", "F", "Ne", };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}