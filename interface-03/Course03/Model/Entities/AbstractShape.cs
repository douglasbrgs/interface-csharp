using Course03.Model.Enums;

namespace Course03.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
