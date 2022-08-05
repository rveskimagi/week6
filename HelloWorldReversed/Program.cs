using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            // kuvab lauset tagurpidi hello word!

            Console.WriteLine("kirjuta : Hello world!");
            string firstName = Console.ReadLine();

            for (int i = firstName.Length - 1; i >=0; i--)
            {
                Console.Write(firstName[i]);
            }
        }
    }
}
