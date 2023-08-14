using System.Globalization;
using System.Text;

namespace Course03.Model.Entities
{
    internal class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append("Rectangle color = ");
            text.Append(Color);
            text.Append(", Width = ");
            text.Append(Width.ToString("F2", CultureInfo.InvariantCulture));
            text.Append(", Height = ");
            text.Append(Height.ToString("F2", CultureInfo.InvariantCulture));
            text.Append(", area = ");
            text.Append(Area().ToString("F2", CultureInfo.InvariantCulture));

            return text.ToString();
        }
    }
}
