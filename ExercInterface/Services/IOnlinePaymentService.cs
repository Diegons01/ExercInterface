namespace ExercInterface.Services
{
    interface IOnlinePaymentService
    {
        //Taxa de pagamento
        double PaymentFee(double amount);
        //Interesse
        double Interest(double amount, int months);

    }
}
