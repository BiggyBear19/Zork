﻿// See https://aka.ms/new-console-template for more information
using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork");

            string inputString = Console.ReadLine();
            inputString = inputString.ToUpper();
            if (inputString == "Quit")
            {
                Console.WriteLine("Thank you for playing.");
            }
            else if (inputString == "Look")
            {
                Console.WriteLine("This is an open field west of a white house, with a boarded front door.\nA rubber mat saying 'Welcome to Zork' lies by the door");
            }
            else
            {
                Console.WriteLine("Unrecognized Command");
            }
        }
    }
}

