using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_140_Heranca_Composicao_Polimorfismo.Entities
{
    internal class OutsourcedEmployee : Employee
    {

        public double additionalChange { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string nome, int hours, double valueHour, double additionalChange) : base(nome, hours, valueHour)
        {
            this.additionalChange = additionalChange;
        }

        public override double Payment()
        {
            double payment = Hours * valueHour;
            double valueadd = 110 / additionalChange * 2 * additionalChange;
            payment += valueadd;
            return payment;
        }
    }
}
