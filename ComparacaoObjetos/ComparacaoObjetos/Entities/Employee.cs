using System;
using System.Globalization;

namespace ComparacaoObjetos.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        //Construtor que recebe o funcionário no formato csv e atribui para as propriedades
        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(",");
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        /*CompareTo = se o objeto que vem como parâmetro for menor que o objeto atual, retorna um número menor que 0
         Se forem iguais retorna 0 e se for maior que o atual retorna um número maior que 0*/
        public int CompareTo(object obj)
        {
            //Se obj não é Employee
            if(!(obj is Employee))
            {
                //Exceção por obj não ser do tipo requerido
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }

            //Downcasting:
            /*Crio uma variável do tipo funcionario que vai receber o obj como funcionario (Downcasting
             Posteriormente eu comparo o Name do objeto atual da classe Employee com o Name */
            Employee other = obj as Employee;

            return Name.CompareTo(other.Name);
        }
    }
}
