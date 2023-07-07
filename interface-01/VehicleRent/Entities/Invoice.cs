using System.Globalization;
using System.Text;

namespace VehicleRent.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get
            {
                return BasicPayment + Tax;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Basic payment: ");
            sb.AppendLine(BasicPayment.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("Tax: ");
            sb.AppendLine(Tax.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("Total payment: ");
            sb.AppendLine(TotalPayment.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
