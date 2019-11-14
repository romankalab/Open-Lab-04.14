using System;
using System.Linq;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            var biggest = strings.OrderByDescending(str => str.Length).First().Length;

            for (var x = 0; x < biggest + 4; x++)
                Console.Write("*");
            Console.WriteLine();

            foreach (var item in strings)
            {
                Console.Write($"* ");
                Console.Write(item);
                for (var x = 0; x < biggest - item.Length; x++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" *");
            }
            for (var x = 0; x < biggest + 4; x++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}