using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerRange = 1;
            int upperRange = 100000;
            string filename = @"E:\ConsoleTest\Testes.txt";
            Random r = new Random();
            int number = 0;
                Console.WriteLine(number);

            using (StreamWriter writer = new StreamWriter(filename, false, Encoding.UTF8))
            {
                
                for (int i = 1; i < 10; i++)
                {
                    number = r.Next(lowerRange, upperRange);

                    writer.WriteLine(number + ",");

                }
               // writer.Flush();
                writer.Close();
            }
        }
    }
}
