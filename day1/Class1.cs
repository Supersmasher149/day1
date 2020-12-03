using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    class Class1
    {
        static void Main(string[] args)
        {
            int Product;
            //reads as an array
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\walte\source\repos\day1\day1\input.txt");

            
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 1; j < lines.Length; j++)
                {
                    int sum = Int32.Parse(lines[i]) + Int32.Parse(lines[j]);
                    //Console.WriteLine(lines[i], "+", lines[j], "=", sum);
                    if (sum == 2020)
                    {
                        int x = Int32.Parse(lines[i]);
                        int y = Int32.Parse(lines[j]);
                        Console.WriteLine($"yay {lines[i]} + {lines[j]} = {x * y}");
                        Product = x * y;
                        break;
                    }
                }
                Console.WriteLine(lines[i]);
            }
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

    }
}
