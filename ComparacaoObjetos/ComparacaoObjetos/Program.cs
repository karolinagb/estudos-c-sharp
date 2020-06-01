using System;
using System.Collections.Generic;
using System.IO;

namespace ComparacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    //list.Sort = para ordenar uma lista
                    list.Sort();
                    foreach(string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }   
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
