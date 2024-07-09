namespace ExInterface.Services
{
    internal interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interests(double amount, int months);

    }
}
