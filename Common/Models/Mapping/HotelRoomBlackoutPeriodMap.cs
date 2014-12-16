using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Common.Models.Mapping
{
    public class HotelRoomBlackoutPeriodMap : EntityTypeConfiguration<HotelRoomBlackoutPeriod>
    {
        public HotelRoomBlackoutPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("HotelRoomBlackoutPeriods");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.HotelRoomId).HasColumnName("HotelRoomId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");

            // Relationships
            this.HasRequired(t => t.HotelRoom)
                .WithMany(t => t.HotelRoomBlackoutPeriods)
                .HasForeignKey(d => d.HotelRoomId);

        }
    }
}
