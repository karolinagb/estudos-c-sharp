using PraticandoComposicao.Entities.Enums;
using System.Collections.Generic;

namespace PraticandoComposicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        //Fazendo a associação das classes HourContract e Department:
        public Department Department { get; set; }

        //Como são vários contratos, terá que ser criado uma propriedade lista:
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
        }

        //Como Contracts é uma lista posso adicionar o novo contarct através da função Add:
        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                }
            }

            return sum;
        }
    }
}
