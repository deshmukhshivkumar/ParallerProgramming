using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Common;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multi Threaded Parallelism");

            Stopwatch sw = Stopwatch.StartNew();

            //Task<int> planeTask = Task.Factory.StartNew<int>(CommonFunctions.BookPlane);
            //Task<int> carTask = Task.Factory.StartNew<int>(CommonFunctions.BookCar);
            //Task<int> hotelTask = Task.Factory.StartNew<int>(CommonFunctions.BookHotel);

            Task<int> planeTask = new Task<int>(CommonFunctions.BookPlane);
            Task<int> carTask = new Task<int>(CommonFunctions.BookCar);
            Task<int> hotelTask = new Task<int>(CommonFunctions.BookHotel);

            planeTask.Start();
            carTask.Start();
            hotelTask.Start();

            Console.WriteLine("Booking Details Plane :{0} Car: {1} Hotel: {2} ", planeTask.Result,
                carTask.Result, hotelTask.Result);

            Console.WriteLine("Booking Time : " + sw.ElapsedMilliseconds / 1000.0);
        }
    }
}
