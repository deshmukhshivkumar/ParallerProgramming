using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class OfferBookingPeriodMapping
    {
        public long OfferId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public virtual Offer Offer { get; set; }
    }
}
