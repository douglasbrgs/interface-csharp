using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course03.Model.Entities
{
    internal class Circle : Shape
    {

        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append("Circle color = ");
            text.Append(Color);
            text.Append(", radius = ");
            text.Append(Radius.ToString("F2", CultureInfo.InvariantCulture));
            text.Append(", area = ");
            text.Append(Area().ToString("F2", CultureInfo.InvariantCulture));

            return text.ToString();
        }
    }
}
