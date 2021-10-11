using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> programs1 = new SortedList<int, string>();
            programs1.Add(1972, "SQL");
            programs1.Add(1995, "JAVA");
            programs1.Add(1991, "PYTHON");
            programs1.Add(2000, "C#");

            Console.WriteLine("ile gore siralama:");
            foreach (var item in programs1)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            Console.WriteLine();

            Console.WriteLine("Ada gore siralama");
            var yerdeyishme = programs1.OrderBy(n => n.Value);
            foreach (var item in yerdeyishme)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
