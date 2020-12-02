using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    class Class1
    {
        static void Main(string[] args)
        {
            //prints as a string
            //string text = System.IO.File.ReadAllText(@"C:\Users\walte\source\repos\day1\day1\input.txt");

            //reads as an array
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\walte\source\repos\day1\day1\input.txt");

            for (int i = 0; i < lines.Length; i++) 
            {
                Console.WriteLine(lines[i]);
            }

            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

    }
}
