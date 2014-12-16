using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Offer
    {
        public Offer()
        {
            this.OfferBookingPeriodMappings = new List<OfferBookingPeriodMapping>();
            this.OfferStayPeriodMappings = new List<OfferStayPeriodMapping>();
        }

        public long Id { get; set; }
        public long HotelId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> AdvancePurchaseDays { get; set; }
        public Nullable<int> MinStayDays { get; set; }
        public Nullable<int> MaxStayDays { get; set; }
        public Nullable<int> FreeNights { get; set; }
        public string PromoText { get; set; }
        public string Description { get; set; }
        public string Scope { get; set; }
        public string AddedBy { get; set; }
        public System.DateTime AddedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public System.DateTime LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsEnabled { get; set; }
        public virtual ICollection<OfferBookingPeriodMapping> OfferBookingPeriodMappings { get; set; }
        public virtual UserHotel UserHotel { get; set; }
        public virtual ICollection<OfferStayPeriodMapping> OfferStayPeriodMappings { get; set; }
    }
}
