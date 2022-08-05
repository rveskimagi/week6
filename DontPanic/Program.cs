using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            // kõik u tähed asendab dont panic nulliga
            // asendab kõik a tähed 4
            string dontP = "Don't Panic!";

            dontP = dontP.Replace('o', '0');
            dontP = dontP.Replace('a', '4');
            Console.WriteLine(dontP);




        }
    }
}
