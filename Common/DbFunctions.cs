using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace Common
{
    public static class DbFunctions
    {
        public static Task<int> AddActivities()
        {
            using (var db = new ContentContext())
            {
                db.Activities.AddRange(GetActivities());
                return db.SaveChangesAsync();
            }

        }

        public static Task<int> AddAirport()
        {
            using (var db = new ContentContext())
            {
                db.Airports.AddRange(GetAirports());
                return db.SaveChangesAsync();
            }
        }

        private static IEnumerable<Activity> GetActivities()
        {
            var activityList = new List<Activity>();
            for (int i = 1; i <= 1000; i++)
            {
                var activity = new Activity()
                {
                    Code = i + "" + new Random().Next(),
                    Category = "Theme Park",
                    Name = "Act" + i,
                    CountryCode = "IN",
                    IsEnabled = true,
                    AddedOn = DateTime.Now,
                    AddedBy = "Shiv",
                    LastModifiedBy = "Shiv",
                    LastModifiedOn = DateTime.Now,
                    Scope = "QQQ",
                    IsDeleted = false
                };

                activityList.Add(activity);
            }
            return activityList;
        }

        private static IEnumerable<Airport> GetAirports()
        {
            var airportList = new List<Airport>();
            for (int i = 1; i <= 400; i++)
            {
                var activity = new Airport()
                {
                    AirportCode = new Random().Next(999).ToString(),
                    AirportName = new Random().Next(999).ToString(),
                    CityCode = "PNQ",
                    CityName = "Pune",
                    CountryCode = "IN",
                    Latitude = (decimal)1.0,
                    Longitude = (decimal)0.0,
                    TimeZoneCode = "T",
                    IsDomestic = false,
                    Preference = 0
                };

                airportList.Add(activity);
            }
            return airportList;
        }
    }


}
