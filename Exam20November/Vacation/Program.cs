using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfAdults = int.Parse(Console.ReadLine());
            var numberOfStudents = int.Parse(Console.ReadLine());
            var numberOfDays = int.Parse(Console.ReadLine());
            var typeOfTransport = Console.ReadLine();

            var trainTickets = 0d;
            var busTickets = 0d;
            var shipTickets = 0d;
            var airplaneTickets = 0d;
            var costHotel = 0d;
            var totalCost = 0d;
            if (numberOfAdults + numberOfStudents < 50)
            {
                trainTickets = (numberOfAdults * 24.99 + numberOfStudents * 14.99);
                busTickets = (numberOfAdults * 32.50 + numberOfStudents * 28.50);
                shipTickets = (numberOfAdults * 42.99 + numberOfStudents * 39.99);
                airplaneTickets = (numberOfAdults * 70.00 + numberOfStudents * 50.00);
            }
            else
            {
                trainTickets = 0.50 * (numberOfAdults * 24.99 + numberOfStudents * 14.99);
                busTickets = (numberOfAdults * 32.50 + numberOfStudents * 28.50);
                shipTickets = (numberOfAdults * 42.99 + numberOfStudents * 39.99);
                airplaneTickets = (numberOfAdults * 70.00 + numberOfStudents * 50.00);
            }

            costHotel = numberOfDays * 82.99;

            switch (typeOfTransport)
            {
                case "train":
                    totalCost = 2 * trainTickets + costHotel + 0.10 * (2 * trainTickets + costHotel);
                    break;

                case "bus":
                    totalCost = 2 * busTickets + costHotel + 0.10 * (2 * busTickets + costHotel);
                    break;

                case "boat":
                    totalCost = 2 * shipTickets + costHotel + 0.10 * (2 * shipTickets + costHotel);
                    break;

                case "airplane":
                    totalCost = 2 * airplaneTickets + costHotel + 0.10 * (2 * airplaneTickets + costHotel);
                    break;

                default:
                    break;
            }
            //totalCost += 0.11;
            Console.WriteLine("{0:F2}" ,totalCost);
        }
    }
}
