namespace VehicleRent.Services
{
    internal class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount > 100)
            {
                return amount * 0.15;
            }
            return amount * 0.2;
        }
    }
}
