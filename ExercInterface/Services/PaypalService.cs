namespace ExercInterface.Services
{
    class PaypalService : IOnlinePaymentService
    {
        //Taxa de pagamento
        public double PaymentFee(double amount)
        {
            amount += amount * 0.02;                       
            return amount;
        }

        public double Interest(double amount, int months)
        {
            amount += amount * 0.01 * months;
            amount = PaymentFee(amount);

            return amount;
        }
    }
}
