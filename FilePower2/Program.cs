using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower2
{
    public class Program
    {
        private static void Main(string[] args)
        {   
            string fileName = args[0];

            Console.WriteLine("Insert phrases:");

            {
                string line;

                using StreamWriter sw = new StreamWriter(fileName);

                while (true)
                {
                    line = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(line))
                    {
                        break;
                    }
                    
                    sw.WriteLine(line);
                }
            }
            Console.WriteLine("Frases guardadas com sucesso!");
        }
    }
}
