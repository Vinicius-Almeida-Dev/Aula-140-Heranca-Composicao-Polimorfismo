using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_140_Heranca_Composicao_Polimorfismo.Entities
{
    internal class Employee
    {
        public string Nome { get; set; }
        public int Hours { get; set; }
        public double valueHour { get; set; }

        public Employee()
        {
        }

        public Employee(string nome, int hours, double valueHour)
        {
            Nome = nome;
            Hours = hours;
            this.valueHour = valueHour;
        }

        public virtual double Payment() { 
        
            return Hours * valueHour;
        }

    }
}
