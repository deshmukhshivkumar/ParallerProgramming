using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Common.Models.Mapping
{
    public class OfferBookingPeriodMappingMap : EntityTypeConfiguration<OfferBookingPeriodMapping>
    {
        public OfferBookingPeriodMappingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OfferId, t.StartDate, t.EndDate });

            // Properties
            this.Property(t => t.OfferId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OfferBookingPeriodMappings");
            this.Property(t => t.OfferId).HasColumnName("OfferId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");

            // Relationships
            this.HasRequired(t => t.Offer)
                .WithMany(t => t.OfferBookingPeriodMappings)
                .HasForeignKey(d => d.OfferId);

        }
    }
}
