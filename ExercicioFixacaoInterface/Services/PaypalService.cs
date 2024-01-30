
namespace ExercicioFixacaoInterface.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MontlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MontlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
