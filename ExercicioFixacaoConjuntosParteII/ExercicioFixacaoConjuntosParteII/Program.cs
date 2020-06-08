using ExercicioFixacaoConjuntosParteII.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExercicioFixacaoConjuntosParteII
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vou usar o mais rápido nesse caso que é o HashSet, já que a ordem não importa*/
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, instant));
                    }
                    //set.Count traz a quantidade de elementos do conjunto:
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
