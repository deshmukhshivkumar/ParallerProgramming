using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Common.Models.Mapping
{
    public class VersionInfoMap : EntityTypeConfiguration<VersionInfo>
    {
        public VersionInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Version);

            // Properties
            this.Property(t => t.Version)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Description)
                .HasMaxLength(1024);

            // Table & Column Mappings
            this.ToTable("VersionInfo");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.AppliedOn).HasColumnName("AppliedOn");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
