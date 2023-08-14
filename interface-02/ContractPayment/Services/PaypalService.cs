namespace ContractPayment.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double feePercentage = 0.02;
        private const double monthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * monthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * feePercentage;
        }
    }
}
