using System;
using System.Collections.Generic;

namespace ExercInterface.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> installments { get; set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }
        
        public void addInstallment(Installment installment)
        {
            installments.Add(installment);
        }

        public void RemoveInstallment(Installment installment)
        {
            installments.Remove(installment);
        }

        public override string ToString()
        {
            return Date
                + " - ";                
        }
    }
}
