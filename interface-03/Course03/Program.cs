using Course03.Model.Entities;
using Course03.Model.Enums;

namespace Course03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Circle()
            {
                Radius = 2.0,
                Color = Color.White
            };

            Shape shape2 = new Rectangle()
            {
                Width = 3.5,
                Height = 4.2,
                Color = Color.Black
            };

            Console.WriteLine(shape1);
            Console.WriteLine(shape2);
        }
    }
}