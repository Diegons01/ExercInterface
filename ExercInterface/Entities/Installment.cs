using System;
using System.Globalization;

namespace ExercInterface.Entities
{
    class Installment
    {
        public DateTime DuolDate { get; set; }
        public double  Amount { get; set; }

        public Installment(DateTime duolDate, double amount)
        {
            DuolDate = duolDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DuolDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
         }
    }
}
