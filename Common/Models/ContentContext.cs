using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Common.Models.Mapping;

namespace Common.Models
{
    public partial class ContentContext : DbContext
    {
        static ContentContext()
        {
            Database.SetInitializer<ContentContext>(null);
        }

        public ContentContext()
            : base("Name=ContentContext")
        {
        }

        public DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityBlackOutPeriod> ActivityBlackOutPeriods { get; set; }
        public DbSet<ActivityOption> ActivityOptions { get; set; }
        public DbSet<AdditionalInformation> AdditionalInformations { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<BoardBasis> BoardBasises { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ClarifiHotelMapping> ClarifiHotelMappings { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<HotelAmenity> HotelAmenities { get; set; }
        public DbSet<HotelBoardBasis> HotelBoardBasises { get; set; }
        public DbSet<HotelRoomBlackoutPeriod> HotelRoomBlackoutPeriods { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<HotelSecondaryInformation> HotelSecondaryInformations { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<OfferBookingPeriodMapping> OfferBookingPeriodMappings { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<OfferStayPeriodMapping> OfferStayPeriodMappings { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ScopeSuppliersMapping> ScopeSuppliersMappings { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<UserHotel> UserHotels { get; set; }
        public DbSet<VersionInfo> VersionInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new C__RefactorLogMap());
            modelBuilder.Configurations.Add(new ActivityMap());
            modelBuilder.Configurations.Add(new ActivityBlackOutPeriodMap());
            modelBuilder.Configurations.Add(new ActivityOptionMap());
            modelBuilder.Configurations.Add(new AdditionalInformationMap());
            modelBuilder.Configurations.Add(new AirportMap());
            modelBuilder.Configurations.Add(new AmenityMap());
            modelBuilder.Configurations.Add(new BoardBasisMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new ClarifiHotelMappingMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new CurrencyMap());
            modelBuilder.Configurations.Add(new HotelAmenityMap());
            modelBuilder.Configurations.Add(new HotelBoardBasisMap());
            modelBuilder.Configurations.Add(new HotelRoomBlackoutPeriodMap());
            modelBuilder.Configurations.Add(new HotelRoomMap());
            modelBuilder.Configurations.Add(new HotelSecondaryInformationMap());
            modelBuilder.Configurations.Add(new ImageMap());
            modelBuilder.Configurations.Add(new OfferBookingPeriodMappingMap());
            modelBuilder.Configurations.Add(new OfferMap());
            modelBuilder.Configurations.Add(new OfferStayPeriodMappingMap());
            modelBuilder.Configurations.Add(new ProductCommentMap());
            modelBuilder.Configurations.Add(new ProductTypeMap());
            modelBuilder.Configurations.Add(new ScopeSuppliersMappingMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new UserHotelMap());
            modelBuilder.Configurations.Add(new VersionInfoMap());
        }
    }
}
