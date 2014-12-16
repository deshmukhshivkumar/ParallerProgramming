using System.Web.Http;
using Common;

namespace WebApplication.Controllers
{
    public class BookingController : ApiController
    {
        public int GetPlaneBookingConfirmationNumber()
        {
            return CommonFunctions.BookPlane();
        }

        public int GetHotelBookingConfirmationNumber()
        {
            return CommonFunctions.BookHotel();
        }

        public int GetCarBookingConfirmationNumber()
        {
            return CommonFunctions.BookCar();
        }
    }
}
