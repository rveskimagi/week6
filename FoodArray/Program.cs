﻿using System;

namespace FoodArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //ennustab mis puuvilja kasutaja sööb

            string[] fruit = new string[5] { "an apple", "a banana", "a lemon", "an orange", "some grapes" };

           // Console.WriteLine(fruit[0]);
            //Console.WriteLine(fruit[1]);

            //Console.WriteLine("enter a number from 0 to 4:");
            Random rnd = new Random();
            int userNumber = rnd.Next(0, fruit.Length);

            Console.WriteLine($"today you will have {fruit[userNumber]}");

        }
    }
}
