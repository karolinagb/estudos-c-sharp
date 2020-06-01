﻿using System;
using System.Collections.Generic;
using System.IO;
using ComparacaoObjetos.Entities;

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
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    //list.Sort = para ordenar uma lista
                    //Para que o Sort possa ordenar ele tem que comparar usando o IComparable na clase Employee
                    list.Sort();

                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
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
