using System;
using System.Collections.Generic;
using System.Globalization;
using Aula_140_Heranca_Composicao_Polimorfismo.Entities;

namespace Aula_140_Heranca_Composicao_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            Console.Write("Enter the number of employeees: ");
            int Entry = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Entry; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced? ");
                char EntryOTSC = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string EntryName = Console.ReadLine();

                Console.Write("Hours: ");
                int EntryHours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double EntryValueHour = double.Parse(Console.ReadLine());

                if (EntryOTSC == 'n')
                {
                    empList.Add(new Employee(EntryName, EntryHours, EntryValueHour));
                }
                else
                {
                    Console.Write("Additional change: ");
                    double EntryATC = double.Parse(Console.ReadLine());

                    empList.Add(new OutsourcedEmployee(EntryName, EntryHours, EntryValueHour, EntryATC));
                }             
            }

            Console.WriteLine();

            Console.WriteLine("PAYMENTS: ");
            foreach (Employee obj in empList)
            {
                Console.WriteLine($"{obj.Nome} - $ {obj.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}

