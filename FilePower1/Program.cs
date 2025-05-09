using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string file = args[0];

            Queue<string> lines = new Queue<string>();

            string frase;


            Console.WriteLine("Insert a sentence or a phrase:");

            while (true)
            {
                frase = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(frase))
                {
                    break;
                }

                lines.Enqueue(frase);
            }

            File.WriteAllLines(file, lines);
            Console.WriteLine("Frases guardadas com sucesso!");
        }
    }
}
