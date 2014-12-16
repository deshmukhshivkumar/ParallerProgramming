using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace SingleThreadParallelism
{
    class Program
    {
        static void Main(string[] args)
        {
            //string html = Downloader.DownloadHtml("http://www.flipkart.com");
            //Console.WriteLine(html);
            Console.WriteLine("Single Threaded Parallelism");
            var sw = Stopwatch.StartNew();
            var planeId = GetPlaneId();
            var hotelId = GetHotelId();
            var carId = GetCarId();

            Console.WriteLine("Booking Details, Plane={0}, Car={1}, Hotel={2} ", planeId.Result, carId.Result, hotelId.Result);
            Console.WriteLine("Time Required For Booking {0} seconds", sw.ElapsedMilliseconds / 1000.0);
        }

        private static async Task<int> GetPlaneId()
        {
            return 
                await CommonFunctions.BookPlaneAsync();
        }

        private static async Task<int> GetCarId()
        {
            return
                await CommonFunctions.BookCarAsync();
        }

        private static async Task<int> GetHotelId()
        {
            return
                await CommonFunctions.BookHotelAsync();
        }
    }
}
