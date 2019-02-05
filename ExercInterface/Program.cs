using System;
using System.Globalization;
using ExercInterface.Entities;
using ExercInterface.Services;

namespace ExercInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Contrato
            Contract contract = new Contract(number, date, value);

            Console.WriteLine();
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());
            //Servico do contrato
            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessContract(contract, installments);

            //contract.addInstallment();

            Console.WriteLine("Installments: ");

            foreach (Installment item in contract.installments)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
