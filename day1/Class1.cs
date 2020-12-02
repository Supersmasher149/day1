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
            //prints as a string
            //string text = System.IO.File.ReadAllText(@"C:\Users\walte\source\repos\day1\day1\input.txt");

            //reads as an array
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\walte\source\repos\day1\day1\input.txt");

            /*
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 1; j < lines.Length; j++)
                {
                    int sum = Int32.Parse(lines[i]) + Int32.Parse(lines[j]);
                    Console.WriteLine(lines[i], "+", lines[j], "=", sum);
                    if (sum == 2020)
                    {
                        string x = lines[i];
                        string y = lines[j];
                        break;
                    }
                }
                Console.WriteLine(lines[i]);
            }
            */

            //Convert array string into int then add and print
            int sum = Int32.Parse(lines[0]) + Int32.Parse(lines[1]);
            Console.WriteLine(sum); 

            //Convert array into string then print
            //int test = Int32.Parse(lines[1]);
            //Console.WriteLine(test);

            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

    }
}
