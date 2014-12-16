using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common
{
    public static class CommonFunctions
    {
        private static Random random = new Random();

        public static int BookPlane()
        {
            Console.WriteLine("Booking plane.." + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("plane booked.");
            return random.Next(100);
        }

        public static int BookCar()
        {
            Console.WriteLine("Booking car.." + +Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("car booked.");
            return random.Next(100);
        }

        public static int BookHotel()
        {
            Console.WriteLine("Booking hotel ..." + +Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("hotel booked.");
            return random.Next(100);
        }

        public static async Task<int> BookPlaneAsync()
        {
            Console.WriteLine("Booking plane.." + Thread.CurrentThread.ManagedThreadId);
            var result = await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("plane booked.");
                return random.Next(100);
            });
            return result;
        }

        public static async Task<int> BookHotelAsync()
        {
            Console.WriteLine("Booking hotel ..." + +Thread.CurrentThread.ManagedThreadId);
            var result = await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("hotel booked.");
                return random.Next(100);
            });
            return result;
        }

        public static async Task<int> BookCarAsync()
        {
            Console.WriteLine("Booking car.." + +Thread.CurrentThread.ManagedThreadId);
            var result = await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("car booked.");
                return random.Next(100);
            });
            return result;
        }
    }
}
