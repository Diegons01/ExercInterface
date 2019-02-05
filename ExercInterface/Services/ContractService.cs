using System;
using ExercInterface.Entities;

namespace ExercInterface.Services
{
    class ContractService
    {
        IOnlinePaymentService _paymentService;

        public ContractService(IOnlinePaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            DateTime time = contract.Date;
            DateTime datePayment = time.AddDays(30);
            //"Melhoria" -> DateTime datePayment = contract.Date.AddMonths(i);

            double installment = 0.0;
            double value = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                installment = _paymentService.Interest(value, i);
                Installment instal = new Installment(datePayment, installment);
                contract.addInstallment(instal);
                //Melhoria -> contract.addInstallment(new Installment(datePayment, installment));

                time = datePayment;
                datePayment = time.AddDays(30);
            }
        }
    }
}
