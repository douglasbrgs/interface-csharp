using Course03.Model.Enums;

namespace Course03.Model.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
