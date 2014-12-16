using System;
using System.Diagnostics;
using Common;

namespace ParallerProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Old Style Programming");

            Stopwatch sw = Stopwatch.StartNew();
            int planeId = CommonFunctions.BookPlane();
            int carId = CommonFunctions.BookCar();
            int hotelId = CommonFunctions.BookHotel();

            Console.WriteLine("Booking Details, Plane={0}, Car={1}, Hotel={2} ", planeId, carId, hotelId);
            Console.WriteLine("Time Required For Booking {0} seconds", sw.ElapsedMilliseconds / 1000.0);
        }
    }
}
