using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace RealWorldSingleThreaded
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();
            Console.WriteLine("Process Started");
            var addActivityTask =  AddActivities();
            var addAirportTask =  AddAirport();
            Console.WriteLine("Tast Stattus  Activity  : {0}  Airport : {1}", addActivityTask.Result , addAirportTask.Result );
            Console.WriteLine("Time Required For Adding 1000 Activities and 400 Airport {0} seconds", sw.ElapsedMilliseconds / 1000.0);
        }

        private static async Task<int> AddActivities()
        {
            return await DbFunctions.AddActivities();
        }

        private static async Task<int> AddAirport()
        {
            return await DbFunctions.AddAirport();
        }

    }
}
