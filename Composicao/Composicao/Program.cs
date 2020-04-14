using System;
using Composicao.Entities;
using Composicao.Entities.Enums;
using System.Globalization;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("\nEnter worker data:");

            Console.Write("\nName: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse <WorkerLevel> (Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciando a entidade departamento:
            Department dept = new Department(deptName);

            //Instanciando o objeto worker que vai ser o trabalhador:
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("\nHow many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEntre com os dados do contrato #{i}:");

                Console.Write("\nDate (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                //Instanciando um contrato:
                HourContract contract = new HourContract(date, valuePerHour, hours);

                //Adicionando o contrato nos contratos do trabalhador:
                worker.AddContract(contract);
            }

            Console.WriteLine();

            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            //Função subtring para cortar:
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.Write("\nName: " + worker.Name);
            Console.Write("\nDepartment: " + worker.Department.Name);
            Console.Write("\nIncome for " + monthAndYear + ": " + worker.Income(year, month));
        }
    }
}
