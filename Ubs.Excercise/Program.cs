using System;

namespace Ubs.Excercise
{
    class Program
    {
        static void  Main(string[] args)
        {
            if (args == null)
            {
                Console.Write("No sentence provided. Please provide sentence");
                return;
            }

            Console.Write(string.Join( " ",args).WordStats());
            
        }
    }
}
