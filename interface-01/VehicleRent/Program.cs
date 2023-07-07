using System;
using System.Globalization;
using VehicleRent.Entities;

namespace VehicleRent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os dados do aluguel");
            Console.Write("Modelo do carro: ");
            string model = Console.ReadLine();
            Console.Write("Data Retirada (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data Devolução (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
        }
    }
}