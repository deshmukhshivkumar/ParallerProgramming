using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Common.Models.Mapping
{
    public class OfferMap : EntityTypeConfiguration<Offer>
    {
        public OfferMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.PromoText)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.Description)
                .HasMaxLength(2048);

            this.Property(t => t.Scope)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.AddedBy)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.LastModifiedBy)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Offers");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.HotelId).HasColumnName("HotelId");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AdvancePurchaseDays).HasColumnName("AdvancePurchaseDays");
            this.Property(t => t.MinStayDays).HasColumnName("MinStayDays");
            this.Property(t => t.MaxStayDays).HasColumnName("MaxStayDays");
            this.Property(t => t.FreeNights).HasColumnName("FreeNights");
            this.Property(t => t.PromoText).HasColumnName("PromoText");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Scope).HasColumnName("Scope");
            this.Property(t => t.AddedBy).HasColumnName("AddedBy");
            this.Property(t => t.AddedOn).HasColumnName("AddedOn");
            this.Property(t => t.LastModifiedBy).HasColumnName("LastModifiedBy");
            this.Property(t => t.LastModifiedOn).HasColumnName("LastModifiedOn");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.IsEnabled).HasColumnName("IsEnabled");

            // Relationships
            this.HasRequired(t => t.UserHotel)
                .WithMany(t => t.Offers)
                .HasForeignKey(d => new { d.HotelId, d.Scope });

        }
    }
}
