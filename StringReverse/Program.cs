﻿using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //kuvab nime tagurpidi

            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();

            for(int i = firstName.Length-1; i >=0; i--)
            {
                Console.Write(firstName[i]);
            }




        }
    }
}
