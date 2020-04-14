using System.Collections.Generic;
using Composicao.Entities.Enums;

namespace Composicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        //Tenho que criar uma propriedade para as associações também:
        public Department Department { get; set; }

        //Como os contratos são vários, terá que ser criado uma lista:
        //Pode-se já instanciar a lista para garantir que ela não seja nula
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            this.Name = name;
            this.Level = level;
            this.BaseSalary = baseSalary;
            this.Department = department;
            //Quanto tiver uma associação para muitos, não colocar no construtor a implementação
        }

        public void AddContract(HourContract contract)
        {
            this.Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            this.Contracts.Remove(contract);
        }

        //Ganho do funcionário:
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            
            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
